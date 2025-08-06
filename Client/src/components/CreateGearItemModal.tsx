import { useState, useCallback, useMemo } from 'react';
import Modal from './Modal';
import { ReactSelector } from './ReactSelector';
import ApiService, { type CreateGearItemDto } from '../utils/apiService';
import { useAppData } from '../contexts/AppDataContext';
import type { GearItem } from '../models/GearItem';

interface CreateGearItemModalProps {
  isOpen: boolean;
  onClose: () => void;
  onItemCreated: (newItem: GearItem) => void;
}

interface CreateGearItemForm {
  name: string;
  categoryName: string;
  selectedSlots: string[];
  selectedJobs: string[];
  stats: CreateGearStatForm[];
}

interface CreateGearStatForm {
  statName: string;
  value: number;
}

const CreateGearItemModal = ({ isOpen, onClose, onItemCreated }: CreateGearItemModalProps) => {
  const { jobs, slots: availableSlots, categories: gearCategories, stats: availableStats, loading: loadingAppData } = useAppData();

  const [formData, setFormData] = useState<CreateGearItemForm>({
    name: '',
    categoryName: '',
    selectedSlots: [],
    selectedJobs: [],
    stats: Array(15).fill(null).map(() => ({ statName: '', value: 0 })), // Start with 15 blank stats
  });
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [urlText, setUrlText] = useState('');
  const [isImportingFromUrl, setIsImportingFromUrl] = useState(false);
  const [urlParseWarnings, setUrlParseWarnings] = useState<string[]>([]);

  const handleSlotToggle = useCallback((slot: string) => {
    setFormData(prev => ({
      ...prev,
      selectedSlots: (() => {
        const current = prev.selectedSlots;
        const isCurrentlySelected = current.includes(slot);
        
        if (isCurrentlySelected) {
          // If currently selected, remove it
          return current.filter(s => s !== slot);
        } else {
          // Special case: Main and Sub can be selected together
          if (slot === 'Main' || slot === 'Sub') {
            const hasMain = current.includes('Main');
            const hasSub = current.includes('Sub');
            
            if (slot === 'Main' && hasSub) {
              // Selecting Main when Sub is already selected - allow both
              return ['Main', 'Sub'];
            } else if (slot === 'Sub' && hasMain) {
              // Selecting Sub when Main is already selected - allow both
              return ['Main', 'Sub'];
            } else {
              // Selecting Main or Sub when the other isn't selected - replace all with this slot
              return [slot];
            }
          } else {
            // For any other slot, only allow one selection
            return [slot];
          }
        }
      })()
    }));
  }, []);

  const handleJobToggle = useCallback((jobAbbreviation: string) => {
    setFormData(prev => ({
      ...prev,
      selectedJobs: prev.selectedJobs.includes(jobAbbreviation)
        ? prev.selectedJobs.filter(j => j !== jobAbbreviation)
        : [...prev.selectedJobs, jobAbbreviation]
    }));
  }, []);

  const handleStatChange = useCallback((index: number, field: 'statName' | 'value', value: string | number) => {
    setFormData(prev => ({
      ...prev,
      stats: prev.stats.map((stat, i) => 
        i === index ? { ...stat, [field]: value } : stat
      )
    }));
  }, []);

  const addStat = useCallback(() => {
    setFormData(prev => ({
      ...prev,
      stats: [...prev.stats, { statName: '', value: 0 }]
    }));
  }, []);

  const removeStat = useCallback((index: number) => {
    setFormData(prev => ({
      ...prev,
      stats: prev.stats.filter((_, i) => i !== index)
    }));
  }, []);

  // Function to parse BG-Wiki URL and populate all fields
  const parseUrlData = useCallback(async (url: string) => {
    const warnings: string[] = [];
    
    // Validate URL is from bg-wiki.com
    if (!url.includes('bg-wiki.com/ffxi/')) {
      setUrlParseWarnings(['URL must be from bg-wiki.com/ffxi/']);
      return;
    }

    setIsImportingFromUrl(true);
    setUrlParseWarnings([]);

    try {
      // Fetch the webpage content via our API
      const response = await fetch('/api/webpage/fetch', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ url })
      });

      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }

      const data = await response.json();

      // Parse the item name
      if (data.name) {
        setFormData(prev => ({ ...prev, name: data.name }));
      }

    // Equipment type only for armor right now
    if (data.equipmentType) {
      let slot = data.equipmentType;
      setFormData(prev => ({ ...prev, selectedSlots: [slot] }));
    }

      // Parse job restrictions
      const jobMap: { [key: string]: string } = {
        'White Mage': 'WHM',
        'Black Mage': 'BLM',
        'Red Mage': 'RDM',
        'Thief': 'THF',
        'Paladin': 'PLD',
        'Dark Knight': 'DRK',
        'Beastmaster': 'BST',
        'Bard': 'BRD',
        'Ranger': 'RNG',
        'Samurai': 'SAM',
        'Ninja': 'NIN',
        'Dragoon': 'DRG',
        'Summoner': 'SMN',
        'Blue Mage': 'BLU',
        'Corsair': 'COR',
        'Puppetmaster': 'PUP',
        'Dancer': 'DNC',
        'Scholar': 'SCH',
        'Geomancer': 'GEO',
        'Rune Fencer': 'RUN'
      };

      const parsedJobs: string[] = [];
      Object.entries(jobMap).forEach(([longName, abbrev]) => {
        if (data.jobs && data.jobs.includes(longName)) {
          parsedJobs.push(abbrev);
        }
      });

      if (parsedJobs.length > 0) {
        setFormData(prev => ({ ...prev, selectedJobs: parsedJobs }));
      }

      // Parse stats from description using the existing parseStatText logic
      if (data.description) {
        // Use the same logic as parseStatText function for consistency
        // Create a mapping of stat names and display names to actual stat names (case-insensitive)
        const statNameMap = new Map<string, string>();
        availableStats.forEach(stat => {
          statNameMap.set(stat.name.toLowerCase(), stat.name);
          if (stat.displayName) {
            statNameMap.set(stat.displayName.toLowerCase(), stat.name);
          }
        });

        const parsedStats: CreateGearStatForm[] = [];
        
        // Special handling for Unity Ranking stats first
        const unityRankingMatches = Array.from(data.description.matchAll(/Unity Ranking:\s*"([^"]+)"\+(\d+)~(\d+)/g));
        for (const unityMatch of unityRankingMatches) {
          const match = unityMatch as RegExpMatchArray;
          const statName = match[1]; // The stat name in quotes (e.g., "Refresh")
          const maxValue = parseInt(match[3], 10); // The value after the ~ (e.g., 2 from +1~2)
          
          if (!isNaN(maxValue)) {
            // Try to find a matching stat (case-insensitive)
            const normalizedStatName = statName.toLowerCase().trim();
            const matchedStatName = statNameMap.get(normalizedStatName);
            
            if (matchedStatName) {
              // Check if this stat is already in our parsed stats
              const existingIndex = parsedStats.findIndex(s => s.statName === matchedStatName);
              if (existingIndex >= 0) {
                // Update existing stat value with the max value
                parsedStats[existingIndex].value += maxValue;
              } else {
                // Add new stat with the max value
                parsedStats.push({ statName: matchedStatName, value: maxValue });
              }
            } else {
              warnings.push(`Could not match Unity Ranking stat: "${statName}"`);
            }
          }
        }

        // Remove Unity Ranking patterns from description for regular parsing
        let cleanedDescription = data.description;
        cleanedDescription = cleanedDescription.replace(/Unity Ranking:\s*"[^"]+"\+\d+~\d+/g, '');

        // Use the same approach as parseStatText: find numeric values first, then extract preceding text
        const valueMatches = Array.from(cleanedDescription.matchAll(/[+-]?\d+%?/g));
        
        if (valueMatches.length > 0) {
          // For each numeric value, try to extract the stat name that precedes it
          for (let i = 0; i < valueMatches.length; i++) {
            const valueMatch = valueMatches[i] as RegExpMatchArray;
            const value = parseInt(valueMatch[0], 10);
            const valueStart = valueMatch.index!;
            
            if (isNaN(value)) continue;
            
            // Determine the start position for the stat name
            // Either from the end of the previous value, or from the beginning of the text
            const prevMatch = valueMatches[i - 1] as RegExpMatchArray;
            const statStart = i > 0 ? prevMatch.index! + prevMatch[0].length : 0;
            
            // Extract the text between the stat start and the current value
            const statText = cleanedDescription.substring(statStart, valueStart).trim();
            
            // Clean up the stat name by removing common separators and extra whitespace
            let statName = statText
              .replace(/^[:\s+\-,]+|[:\s+\-,]+$/g, '') // Remove leading/trailing separators
              .replace(/\s+/g, ' ') // Normalize whitespace
              .replace(/^["']|["']$/g, '') // Remove surrounding quotes
              .trim();
            
            // Handle cases where the stat name might have quotes in the middle
            // Remove quotes but preserve the content
            statName = statName.replace(/["']/g, '');
            
            if (statName) {
              // Try to find an exact matching stat (case-insensitive)
              const normalizedStatName = statName.toLowerCase().trim();
              const matchedStatName = statNameMap.get(normalizedStatName);
              
              if (matchedStatName) {
                // Check if this stat is already in our parsed stats
                const existingIndex = parsedStats.findIndex(s => s.statName === matchedStatName);
                if (existingIndex >= 0) {
                  // Update existing stat value
                  parsedStats[existingIndex].value += value;
                } else {
                  // Add new stat
                  parsedStats.push({ statName: matchedStatName, value });
                }
              } else {
                warnings.push(`Could not match stat: "${statName}"`);
              }
            }
          }
        }

        // Update stats in form
        if (parsedStats.length > 0) {
          setFormData(prev => ({
            ...prev,
            stats: [
              ...parsedStats,
              ...Array(Math.max(0, 15 - parsedStats.length)).fill(null).map(() => ({ statName: '', value: 0 }))
            ]
          }));
        }
      }

      // Add any warnings from the backend
      if (data.warnings && data.warnings.length > 0) {
        warnings.push(...data.warnings);
      }

      setUrlParseWarnings(warnings);
      
      // Clear the URL field after successful import
      setUrlText('');

    } catch (error) {
      console.error('Error parsing URL data:', error);
      setUrlParseWarnings([`Failed to parse URL: ${error instanceof Error ? error.message : 'Unknown error'}`]);
    } finally {
      setIsImportingFromUrl(false);
    }
  }, [availableStats]);

  const handleUrlImport = useCallback(() => {
    if (urlText.trim()) {
      parseUrlData(urlText.trim());
    }
  }, [urlText, parseUrlData]);

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    setIsSubmitting(true);
    setError(null);

    try {
      const createData: CreateGearItemDto = {
        name: formData.name.trim(),
        categoryName: formData.categoryName || undefined,
        slots: formData.selectedSlots,
        jobs: formData.selectedJobs,
        stats: formData.stats
          .filter(stat => stat.statName.trim() && stat.value !== 0)
          .map(stat => ({ statName: stat.statName.trim(), value: stat.value }))
      };

      const newItem = await ApiService.createGearItem(createData);
      onItemCreated(newItem);
      resetForm();
      onClose();
    } catch (err) {
      console.error('Error creating gear item:', err);
      setError(err instanceof Error ? err.message : 'Failed to create gear item. Please try again.');
    } finally {
      setIsSubmitting(false);
    }
  };

  const resetForm = () => {
    setFormData({
      name: '',
      categoryName: '',
      selectedSlots: [],
      selectedJobs: [],
      stats: Array(15).fill(null).map(() => ({ statName: '', value: 0 })), // Reset to 15 blank stats
    });
    setError(null);
    setUrlText('');
    setUrlParseWarnings([]);
  };

  const handleClose = () => {
    resetForm();
    onClose();
  };

  // Memoize slot and job selection state for better performance
  const slotSelectionMap = useMemo(() => new Set(formData.selectedSlots), [formData.selectedSlots]);
  const jobSelectionMap = useMemo(() => new Set(formData.selectedJobs), [formData.selectedJobs]);

  // Memoize stat options for ReactSelector
  const statOptions = useMemo(() => 
    availableStats.map(stat => ({
      value: stat.name,
      label: stat.displayName || stat.name
    }))
  , [availableStats]);

  // Updated form validation to require at least one valid stat
  const hasValidStats = formData.stats.some(stat => stat.statName.trim() && stat.value !== 0);
  const isFormValid = formData.name.trim() && formData.selectedSlots.length > 0 && hasValidStats;

  return (
    <Modal isOpen={isOpen} onClose={handleClose} size="xl">
      {loadingAppData ? (
        <div className="p-4 text-center">
          <div className="animate-spin rounded-full h-6 w-6 border-b-2 border-blue-600 mx-auto"></div>
          <p className="mt-2 text-sm text-gray-600 dark:text-gray-400">Loading...</p>
        </div>
      ) : (
        <div className="p-6 space-y-6 h-full flex flex-col">
          <div>
            <h3 className="text-lg font-semibold text-gray-900 dark:text-gray-100 mb-2">
              Create New Gear Item
            </h3>
            <p className="text-sm text-gray-600 dark:text-gray-400">
              Create a new gear item with name, category, slots, job restrictions, and stats:
            </p>
          </div>

          {error && (
            <div className="p-3 bg-red-100 border border-red-400 text-red-700 rounded">
              {error}
            </div>
          )}

          <form onSubmit={handleSubmit} className="space-y-6 flex flex-col flex-1 min-h-0">
            {/* Two Column Layout */}
            <div className="grid grid-cols-1 lg:grid-cols-2 gap-8 flex-1 min-h-0">
              {/* Left Column - Basic Info */}
              <div className="space-y-6">
                <div>
                  <h4 className="text-base font-medium text-gray-900 dark:text-gray-100 mb-4 pb-2 border-b border-gray-200 dark:border-gray-700">
                    Basic Information
                  </h4>
                  
                  {/* Name Field */}
                  <div className="mb-4">
                    <label htmlFor="name" className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2">
                      Name *
                    </label>
                    <input
                      type="text"
                      id="name"
                      name="gear-name"
                      value={formData.name}
                      onChange={(e) => setFormData(prev => ({ ...prev, name: e.target.value }))}
                      required
                      autoComplete="off"
                      data-lpignore="true"
                      data-form-type="other"
                      className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                      placeholder="e.g., Excalibur, Hauberk, etc."
                    />
                  </div>

                  {/* Category Field */}
                  <div>
                    <label htmlFor="category" className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2">
                      Category
                    </label>
                    <select
                      id="category"
                      name="gear-category"
                      value={formData.categoryName}
                      onChange={(e) => setFormData(prev => ({ ...prev, categoryName: e.target.value }))}
                      autoComplete="off"
                      data-lpignore="true"
                      className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                    >
                      <option value="">No Category</option>
                      {gearCategories.map(category => (
                        <option key={category} value={category}>
                          {category}
                        </option>
                      ))}
                    </select>
                  </div>
                </div>

                {/* Slots Section */}
                <div>
                  <h4 className="text-sm font-medium text-gray-700 dark:text-gray-300 mb-2">
                    Equipment Slots *
                  </h4>
                  <p className="text-xs text-gray-600 dark:text-gray-400 mb-3">
                    Select which equipment slots this item can be used in:
                  </p>
                  <div className="grid grid-cols-2 sm:grid-cols-3 gap-2">
                    {availableSlots.map(slot => {
                      const isSelected = slotSelectionMap.has(slot);
                      return (
                        <label
                          key={slot}
                          className={`
                            flex items-center space-x-2 p-2 rounded border cursor-pointer transition-colors
                            ${isSelected
                              ? 'bg-blue-50 border-blue-300 text-blue-900 dark:bg-blue-900/20 dark:border-blue-600 dark:text-blue-100'
                              : 'bg-gray-50 border-gray-300 text-gray-700 hover:bg-gray-100 dark:bg-gray-800 dark:border-gray-600 dark:text-gray-300 dark:hover:bg-gray-700'
                            }
                          `}
                        >
                          <input
                            type="checkbox"
                            checked={isSelected}
                            onChange={() => handleSlotToggle(slot)}
                            className="w-4 h-4 text-blue-600 bg-gray-100 border-gray-300 rounded focus:ring-blue-500 dark:bg-gray-700 dark:border-gray-600"
                          />
                          <span className="text-sm font-medium capitalize">{slot}</span>
                        </label>
                      );
                    })}
                  </div>
                  <div className="mt-2 text-xs text-gray-600 dark:text-gray-400">
                    {formData.selectedSlots.length} slot{formData.selectedSlots.length !== 1 ? 's' : ''} selected
                  </div>
                </div>

                {/* Jobs Section */}
                <div>
                  <h4 className="text-sm font-medium text-gray-700 dark:text-gray-300 mb-2">
                    Job Restrictions
                  </h4>
                  <p className="text-xs text-gray-600 dark:text-gray-400 mb-3">
                    Leave all jobs unselected if ALL jobs can use this item:
                  </p>
                  <div className="grid grid-cols-3 sm:grid-cols-4 gap-2">
                    {jobs.map(job => {
                      const isSelected = jobSelectionMap.has(job.abbreviation);
                      return (
                        <label
                          key={job.abbreviation}
                          className={`
                            flex items-center space-x-2 p-2 rounded border cursor-pointer transition-colors
                            ${isSelected
                              ? 'bg-green-50 border-green-300 text-green-900 dark:bg-green-900/20 dark:border-green-600 dark:text-green-100'
                              : 'bg-gray-50 border-gray-300 text-gray-700 hover:bg-gray-100 dark:bg-gray-800 dark:border-gray-600 dark:text-gray-300 dark:hover:bg-gray-700'
                            }
                          `}
                        >
                          <input
                            type="checkbox"
                            checked={isSelected}
                            onChange={() => handleJobToggle(job.abbreviation)}
                            className="w-4 h-4 text-green-600 bg-gray-100 border-gray-300 rounded focus:ring-green-500 dark:bg-gray-700 dark:border-gray-600"
                          />
                          <span className="text-sm font-medium">{job.abbreviation}</span>
                        </label>
                      );
                    })}
                  </div>
                  <div className="mt-2 text-xs text-gray-600 dark:text-gray-400">
                    {formData.selectedJobs.length === 0 
                      ? 'Available to ALL jobs' 
                      : `${formData.selectedJobs.length} job${formData.selectedJobs.length !== 1 ? 's' : ''} selected`
                    }
                  </div>
                </div>
              </div>

              {/* Right Column - Stats */}
              <div className="space-y-6 flex flex-col min-h-0">
                {/* URL Import */}
                <div>
                  <h4 className="text-base font-medium text-gray-900 dark:text-gray-100 mb-2 pb-2 border-b border-gray-200 dark:border-gray-700">
                    🚀 URL Import
                  </h4>
                  <p className="text-xs text-gray-600 dark:text-gray-400 mb-3">
                    Paste a bg-wiki.com URL to automatically import ALL gear data (name, slots, jobs, stats):
                  </p>
                  <div className="space-y-2">
                    <input
                      type="url"
                      value={urlText}
                      onChange={(e) => setUrlText(e.target.value)}
                      placeholder="https://www.bg-wiki.com/ffxi/Contemplator_%2B1"
                      className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500 text-xs"
                      autoComplete="off"
                      data-lpignore="true"
                      data-form-type="other"
                    />
                    <div className="flex space-x-2">
                      <button
                        type="button"
                        onClick={handleUrlImport}
                        disabled={!urlText.trim() || isImportingFromUrl}
                        className="px-3 py-1 text-xs font-medium text-white bg-purple-600 border border-transparent rounded hover:bg-purple-700 focus:outline-none focus:ring-2 focus:ring-purple-500 disabled:opacity-50 disabled:cursor-not-allowed"
                      >
                        {isImportingFromUrl ? (
                          <div className="flex items-center space-x-1">
                            <div className="animate-spin rounded-full h-3 w-3 border-b border-white"></div>
                            <span>Importing...</span>
                          </div>
                        ) : (
                          'Import from URL'
                        )}
                      </button>
                    </div>
                  </div>
                  
                  {/* URL Parse Warnings */}
                  {urlParseWarnings.length > 0 && (
                    <div className="mt-2 p-2 bg-yellow-50 border border-yellow-200 rounded text-xs dark:bg-yellow-900/20 dark:border-yellow-700">
                      <div className="font-medium text-yellow-800 dark:text-yellow-200 mb-1">URL Import Notes:</div>
                      <ul className="text-yellow-700 dark:text-yellow-300 space-y-1">
                        {urlParseWarnings.map((warning, index) => (
                          <li key={index}>• {warning}</li>
                        ))}
                      </ul>
                    </div>
                  )}
                </div>

                <div className="flex flex-col flex-1 min-h-0">
                  <div className="flex items-center justify-between mb-2">
                    <h4 className="text-base font-medium text-gray-900 dark:text-gray-100 pb-2 border-b border-gray-200 dark:border-gray-700 w-full">
                      Stats *
                    </h4>
                  </div>
                  <div className="flex items-center justify-between mb-3">
                    <p className="text-xs text-gray-600 dark:text-gray-400">
                      Add at least one stat with a non-zero value:
                    </p>
                    <button
                      type="button"
                      onClick={addStat}
                      className="px-2 py-1 text-xs font-medium text-blue-600 border border-blue-600 rounded hover:bg-blue-50 dark:text-blue-400 dark:border-blue-400 dark:hover:bg-blue-900/20 cursor-pointer"
                    >
                      Add Stat
                    </button>
                  </div>
                  
                  <div className="space-y-3 flex-1 min-h-0 overflow-y-auto">
                    {formData.stats.map((stat, index) => (
                      <div key={index} className="flex items-center space-x-2">
                        <div className="flex-1">
                          <ReactSelector
                            value={statOptions.find(option => option.value === stat.statName) || null}
                            onChange={(selectedOption) => handleStatChange(index, 'statName', selectedOption?.value || '')}
                            options={statOptions}
                            placeholder="Select a stat..."
                            isClearable
                            isSearchable
                          />
                        </div>
                        <div className="w-24">
                          <input
                            type="number"
                            value={stat.value}
                            onChange={(e) => handleStatChange(index, 'value', parseInt(e.target.value, 10) || 0)}
                            placeholder="Value"
                            className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                            autoComplete="off"
                            data-lpignore="true"
                            data-form-type="other"
                          />
                        </div>
                        {formData.stats.length > 15 && (
                          <button
                            type="button"
                            onClick={() => removeStat(index)}
                            className="p-2 text-red-600 hover:bg-red-50 rounded dark:text-red-400 dark:hover:bg-red-900/20"
                            title="Remove stat"
                          >
                            <svg className="w-4 h-4" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                              <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M6 18L18 6M6 6l12 12" />
                            </svg>
                          </button>
                        )}
                      </div>
                    ))}
                  </div>
                  <div className="mt-3 text-xs text-gray-600 dark:text-gray-400">
                    {hasValidStats 
                      ? `${formData.stats.filter(s => s.statName.trim() && s.value !== 0).length} valid stat${formData.stats.filter(s => s.statName.trim() && s.value !== 0).length !== 1 ? 's' : ''} configured`
                      : 'At least one stat with a non-zero value is required'
                    }
                  </div>
                </div>
              </div>
            </div>

            {/* Form Actions */}
            <div className="flex justify-between items-center pt-4 border-t border-gray-200 dark:border-gray-700 flex-shrink-0">
              <div className="text-sm text-gray-600 dark:text-gray-400">
                {isFormValid ? 'Ready to create gear item' : 'Name, at least one slot, and one valid stat required'}
              </div>
              
              <div className="flex space-x-2">
                <button
                  type="button"
                  onClick={handleClose}
                  disabled={isSubmitting}
                  className="px-4 py-2 text-sm font-medium text-gray-700 bg-gray-100 border border-gray-300 rounded-md hover:bg-gray-200 focus:outline-none focus:ring-2 focus:ring-gray-500 disabled:opacity-50 dark:bg-gray-700 dark:text-gray-300 dark:border-gray-600 dark:hover:bg-gray-600 cursor-pointer"
                >
                  Cancel
                </button>
                <button
                  type="submit"
                  disabled={!isFormValid || isSubmitting}
                  className="px-4 py-2 text-sm font-medium text-white bg-blue-600 border border-transparent rounded-md hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-500 disabled:opacity-50 cursor-pointer"
                >
                  {isSubmitting ? (
                    <div className="flex items-center space-x-2">
                      <div className="animate-spin rounded-full h-4 w-4 border-b-2 border-white"></div>
                      <span>Creating...</span>
                    </div>
                  ) : (
                    'Create Gear Item'
                  )}
                </button>
              </div>
            </div>
          </form>
        </div>
      )}
    </Modal>
  );
};

export default CreateGearItemModal;
