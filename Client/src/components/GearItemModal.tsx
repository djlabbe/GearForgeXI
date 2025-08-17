import { useState, useCallback, useMemo, useEffect } from "react";
import Modal from "./Modal";
import { ReactSelector } from "./ReactSelector";
import { GearService, type CreateGearItemDto } from "../services";
import { useAppData } from "../contexts/AppDataContext";
import type { GearItem } from "../models/GearItem";
import { authFetch } from "../utils/authFetch";

interface GearItemModalProps {
  isOpen: boolean;
  onClose: () => void;
  onItemCreated: (newItem: GearItem, isEdit: boolean) => void;
  editingItem?: GearItem | null; // Optional existing item to edit
}

interface CreateGearItemForm {
  name: string;
  categoryName: string;
  rank?: number;
  path?: string;
  verified: boolean;
  selectedSlots: string[];
  selectedJobs: string[];
  stats: CreateGearStatForm[];
}

interface CreateGearStatForm {
  statName: string;
  value: number | null;
}

const GearItemModal = ({
  isOpen,
  onClose,
  onItemCreated,
  editingItem,
}: GearItemModalProps) => {
  const {
    jobs,
    slots: availableSlots,
    categories: gearCategories,
    stats: availableStats,
    loading: loadingAppData,
  } = useAppData();

  //   const isEditing = Boolean(editingItem);

  // Initialize form data based on whether we're editing or creating
  const getInitialFormData = useCallback((): CreateGearItemForm => {
    if (editingItem) {
      return {
        name: editingItem.name,
        categoryName: editingItem.category || "",
        rank: editingItem.rank,
        path: editingItem.path,
        verified: editingItem.verified || false,
        selectedSlots: editingItem.slots,
        selectedJobs: editingItem.jobs,
        stats: [
          ...editingItem.stats.map((stat: any) => ({
            statName: stat.name,
            value: stat.value,
          })),
          ...Array(Math.max(0, 15 - editingItem.stats.length))
            .fill(null)
            .map(() => ({ statName: "", value: null })),
        ],
      };
    }
    return {
      name: "",
      categoryName: "",
      rank: undefined,
      path: "",
      verified: false,
      selectedSlots: [],
      selectedJobs: [],
      stats: Array(15)
        .fill(null)
        .map(() => ({ statName: "", value: null })),
    };
  }, [editingItem]);

  const [formData, setFormData] =
    useState<CreateGearItemForm>(getInitialFormData);
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [urlText, setUrlText] = useState("");
  const [isImportingFromUrl, setIsImportingFromUrl] = useState(false);
  const [urlParseWarnings, setUrlParseWarnings] = useState<string[]>([]);

  // Reset form data when editingItem changes
  useEffect(() => {
    setFormData(getInitialFormData());
    setError(null);
    // When editing an item, default the BG-Wiki input to the item's name
    setUrlText(editingItem ? editingItem.name : "");
    setUrlParseWarnings([]);
  }, [editingItem, getInitialFormData]);

  const handleSlotToggle = useCallback((slot: string) => {
    setFormData((prev) => ({
      ...prev,
      selectedSlots: (() => {
        const current = prev.selectedSlots;
        const isCurrentlySelected = current.includes(slot);

        if (isCurrentlySelected) {
          // If currently selected, remove it
          return current.filter((s) => s !== slot);
        } else {
          // Special case: Main and Sub can be selected together
          if (slot === "Main" || slot === "Sub") {
            const hasMain = current.includes("Main");
            const hasSub = current.includes("Sub");

            if (slot === "Main" && hasSub) {
              // Selecting Main when Sub is already selected - allow both
              return ["Main", "Sub"];
            } else if (slot === "Sub" && hasMain) {
              // Selecting Sub when Main is already selected - allow both
              return ["Main", "Sub"];
            } else {
              // Selecting Main or Sub when the other isn't selected - replace all with this slot
              return [slot];
            }
          } else {
            // For any other slot, only allow one selection
            return [slot];
          }
        }
      })(),
    }));
  }, []);

  const handleJobToggle = useCallback((jobAbbreviation: string) => {
    setFormData((prev) => ({
      ...prev,
      selectedJobs: prev.selectedJobs.includes(jobAbbreviation)
        ? prev.selectedJobs.filter((j) => j !== jobAbbreviation)
        : [...prev.selectedJobs, jobAbbreviation],
    }));
  }, []);

  const handleStatChange = useCallback(
    (index: number, field: "statName" | "value", value: string | number | null) => {
      setFormData((prev) => ({
        ...prev,
        stats: prev.stats.map((stat, i) =>
          i === index ? { ...stat, [field]: value } : stat
        ),
      }));
    },
    []
  );

  const addStat = useCallback(() => {
    setFormData((prev) => ({
      ...prev,
      stats: [...prev.stats, { statName: "", value: null }],
    }));
  }, []);

  const removeStat = useCallback((index: number) => {
    setFormData((prev) => ({
      ...prev,
      stats: prev.stats.filter((_, i) => i !== index),
    }));
  }, []);

  // Function to parse BG-Wiki URL and populate all fields
  const parseUrlData = useCallback(
    async (input: string) => {
      let url = input.trim();
      
      // If input doesn't look like a URL, treat it as an item name and construct the URL
      if (!url.startsWith('http') && !url.startsWith('www.')) {
        // Replace spaces with underscores, then encode the entire string
        // encodeURIComponent will properly handle +, ', and other special characters
        const itemName = url.replace(/\s+/g, '_');
        url = `https://www.bg-wiki.com/ffxi/${encodeURIComponent(itemName)}`;
      }
      
      // Validate URL is from bg-wiki.com
      if (!url.includes("bg-wiki.com/ffxi/")) {
        setUrlParseWarnings(["URL must be from bg-wiki.com/ffxi/ or provide a valid item name"]);
        return;
      }

      // Open the final URL in a new tab
      window.open(url, '_blank', 'noopener,noreferrer');

      setIsImportingFromUrl(true);
      setUrlParseWarnings([]);

      try {
        // Fetch the webpage content via our API
        const response = await authFetch("/api/webpage/fetch", {
          method: "POST",
          headers: { "Content-Type": "application/json" },
          body: JSON.stringify({ url }),
        });

        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`);
        }

        const data = await response.json();

        // Parse the item name
        if (data.name) {
          setFormData((prev) => ({ ...prev, name: data.name }));
        }

        // Parse equipment slot (now comes as a single slot name)
        if (data.equipmentSlot) {
          setFormData((prev) => ({
            ...prev,
            selectedSlots: [data.equipmentSlot],
          }));
        }

        // Parse job restrictions (now comes as array of job abbreviations)
        if (data.jobs && Array.isArray(data.jobs) && data.jobs.length > 0) {
          setFormData((prev) => ({ ...prev, selectedJobs: data.jobs }));
        }

        // Parse stats (now comes pre-parsed from backend)
        if (data.stats && Array.isArray(data.stats) && data.stats.length > 0) {
          const parsedStats: CreateGearStatForm[] = data.stats.map(
            (stat: any) => ({
              statName: stat.statName,
              value: stat.value,
            })
          );

          setFormData((prev) => ({
            ...prev,
            stats: [
              ...parsedStats,
              ...Array(Math.max(0, 15 - parsedStats.length))
                .fill(null)
                .map(() => ({ statName: "", value: 0 })),
            ],
          }));
        }

        // Add any warnings from the backend
        if (data.warnings && data.warnings.length > 0) {
          setUrlParseWarnings(data.warnings);
        } else {
          setUrlParseWarnings([]);
        }

        // Clear the URL field after successful import
        setUrlText("");
      } catch (error) {
        console.error("Error parsing URL data:", error);
        setUrlParseWarnings([
          `Failed to parse URL: ${
            error instanceof Error ? error.message : "Unknown error"
          }`,
        ]);
      } finally {
        setIsImportingFromUrl(false);
      }
    },
    [] // No longer depends on availableStats since parsing is done on backend
  );

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
        rank: formData.rank,
        path: formData.path || undefined,
        verified: formData.verified,
        slots: formData.selectedSlots,
        jobs: formData.selectedJobs,
        stats: formData.stats
          .filter((stat) => stat.statName.trim()) // Include stats with a name, regardless of value
          .map((stat) => ({
            statName: stat.statName.trim(),
            value: stat.value,
          })),
      };

      let updatedItem: GearItem;
      const isEdit = Boolean(editingItem);
      if (editingItem) {
        // Update existing item
        updatedItem = await GearService.updateGearItem(
          editingItem.id,
          createData
        );
      } else {
        // Create new item
        updatedItem = await GearService.createGearItem(createData);
      }

      onItemCreated(updatedItem, isEdit);
      resetForm();
      onClose();
    } catch (err) {
      console.error(
        `Error ${editingItem ? "updating" : "creating"} gear item:`,
        err
      );
      setError(
        err instanceof Error
          ? err.message
          : `Failed to ${
              editingItem ? "update" : "create"
            } gear item. Please try again.`
      );
    } finally {
      setIsSubmitting(false);
    }
  };

  const resetForm = () => {
    setFormData(getInitialFormData());
    setError(null);
    setUrlText("");
    setUrlParseWarnings([]);
  };

  const handleClose = () => {
    resetForm();
    onClose();
  };

  // Memoize slot and job selection state for better performance
  const slotSelectionMap = useMemo(
    () => new Set(formData.selectedSlots),
    [formData.selectedSlots]
  );
  const jobSelectionMap = useMemo(
    () => new Set(formData.selectedJobs),
    [formData.selectedJobs]
  );

  // Memoize stat options for ReactSelector
  const statOptions = useMemo(
    () =>
      availableStats.map((stat) => ({
        value: stat.name,
        label: stat.displayName || stat.name,
      })),
    [availableStats]
  );

  // Updated form validation to require at least one valid stat
  const hasValidStats = formData.stats.some(
    (stat) => stat.statName.trim() && stat.value !== 0
  );
  const isFormValid =
    formData.name.trim() && formData.selectedSlots.length > 0 && hasValidStats;

  return (
    <Modal isOpen={isOpen} onClose={handleClose} customWidth="80vw">
      {loadingAppData ? (
        <div className="p-4 text-center">
          <div className="animate-spin rounded-full h-6 w-6 border-b-2 border-blue-600 mx-auto"></div>
          <p className="mt-2 text-sm text-gray-600 dark:text-gray-400">
            Loading...
          </p>
        </div>
      ) : (
        <div className="p-6 space-y-6 h-full flex flex-col">
          <div>
            <h3 className="text-lg font-semibold text-gray-900 dark:text-gray-100 mb-2">
              {editingItem ? "Edit Gear Item" : "Create New Gear Item"}
            </h3>
            <p className="text-sm text-gray-600 dark:text-gray-400">
              {editingItem
                ? "Update the gear item with new information:"
                : "Create a new gear item with name, category, slots, job restrictions, and stats:"}
            </p>
          </div>

          {error && (
            <div className="p-3 bg-red-100 border border-red-400 text-red-700 rounded">
              {error}
            </div>
          )}

          <form
            onSubmit={handleSubmit}
            className="space-y-6 flex flex-col flex-1 min-h-0"
          >
            {/* Three Column Layout */}
            <div className="grid grid-cols-1 xl:grid-cols-3 gap-6 flex-1 min-h-0">
              {/* First Column - Import & Basic Info */}
              <div className="space-y-6">
                {/* URL Import */}
                <div>
                  <h4 className="text-base font-medium text-gray-900 dark:text-gray-100 mb-2 pb-2 border-b border-gray-200 dark:border-gray-700">
                    🚀 BG-Wiki Import
                  </h4>
                  <p className="text-xs text-gray-600 dark:text-gray-400 mb-3">
                    {editingItem
                      ? "Paste a bg-wiki.com URL or just the item name to update ALL gear data from the wiki:"
                      : "Paste a bg-wiki.com URL or just the item name to automatically import ALL gear data (name, slots, jobs, stats):"}
                  </p>
                  <div className="space-y-2">
                    <input
                      type="text"
                      value={urlText}
                      onChange={(e) => setUrlText(e.target.value)}
                      placeholder="Contemplator +1  or  https://www.bg-wiki.com/ffxi/Contemplator_%2B1"
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
                        className="px-3 py-1 text-xs font-medium text-white bg-purple-600 border border-transparent rounded hover:bg-purple-700 focus:outline-none focus:ring-2 focus:ring-purple-500 disabled:opacity-50 disabled:cursor-not-allowed cursor-pointer disabled:cursor-not-allowed"
                      >
                        {isImportingFromUrl ? (
                          <div className="flex items-center space-x-1">
                            <div className="animate-spin rounded-full h-3 w-3 border-b border-white"></div>
                            <span>
                              {editingItem ? "Updating..." : "Importing..."}
                            </span>
                          </div>
                        ) : editingItem ? (
                          "Update from URL"
                        ) : (
                          "Import from URL"
                        )}
                      </button>
                    </div>
                  </div>

                  {/* URL Parse Warnings */}
                  {urlParseWarnings.length > 0 && (
                    <div className="mt-2 p-2 bg-yellow-50 border border-yellow-200 rounded text-xs dark:bg-yellow-900/20 dark:border-yellow-700">
                      <div className="font-medium text-yellow-800 dark:text-yellow-200 mb-1">
                        Import Warnings:
                      </div>
                      <ul className="text-yellow-700 dark:text-yellow-300 space-y-1">
                        {urlParseWarnings.map((warning, index) => (
                          <li key={index}>• {warning}</li>
                        ))}
                      </ul>
                    </div>
                  )}
                </div>

                {/* Basic Information */}
                <div>
                  <h4 className="text-base font-medium text-gray-900 dark:text-gray-100 mb-4 pb-2 border-b border-gray-200 dark:border-gray-700">
                    Basic Information
                  </h4>

                  {/* Name Field */}
                  <div className="mb-4">
                    <label
                      htmlFor="name"
                      className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
                    >
                      Name *
                    </label>
                    <input
                      type="text"
                      id="name"
                      name="gear-name"
                      value={formData.name}
                      onChange={(e) =>
                        setFormData((prev) => ({
                          ...prev,
                          name: e.target.value,
                        }))
                      }
                      required
                      autoComplete="off"
                      data-lpignore="true"
                      data-form-type="other"
                      className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                      placeholder="e.g., Excalibur, Hauberk, etc."
                    />
                  </div>

                  {/* Rank Field */}
                  <div className="mb-4">
                    <label
                      htmlFor="rank"
                      className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
                    >
                      Rank
                    </label>
                    <input
                      type="number"
                      id="rank"
                      name="gear-rank"
                      value={formData.rank || ""}
                      onChange={(e) =>
                        setFormData((prev) => ({
                          ...prev,
                          rank: e.target.value ? parseInt(e.target.value) : undefined,
                        }))
                      }
                      autoComplete="off"
                      min="0"
                      max="30"
                      className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                      placeholder="e.g., 15, 20, 25, 30"
                    />
                  </div>

                  {/* Path Field */}
                  <div className="mb-4">
                    <label
                      htmlFor="path"
                      className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
                    >
                      Path
                    </label>
                    <select
                      id="path"
                      name="gear-path"
                      value={formData.path || ""}
                      onChange={(e) =>
                        setFormData((prev) => ({
                          ...prev,
                          path: e.target.value || undefined,
                        }))
                      }
                      autoComplete="off"
                      data-lpignore="true"
                      className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                    >
                      <option value="">No Path</option>
                      <option value="A">A</option>
                      <option value="B">B</option>
                      <option value="C">C</option>
                      <option value="D">D</option>
                    </select>
                  </div>

                  {/* Category Field */}
                  <div className="mb-4">
                    <label
                      htmlFor="category"
                      className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
                    >
                      Category
                    </label>
                    <select
                      id="category"
                      name="gear-category"
                      value={formData.categoryName}
                      onChange={(e) =>
                        setFormData((prev) => ({
                          ...prev,
                          categoryName: e.target.value,
                        }))
                      }
                      autoComplete="off"
                      data-lpignore="true"
                      className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                    >
                      <option value="">No Category</option>
                      {gearCategories.map((category) => (
                        <option key={category} value={category}>
                          {category}
                        </option>
                      ))}
                    </select>
                  </div>

                  {/* Verified Toggle */}
                  <div className="flex items-center space-x-3">
                    <input
                      type="checkbox"
                      id="verified"
                      name="gear-verified"
                      checked={formData.verified}
                      onChange={(e) =>
                        setFormData((prev) => ({
                          ...prev,
                          verified: e.target.checked,
                        }))
                      }
                      className="w-4 h-4 text-green-600 bg-gray-100 border-gray-300 rounded focus:ring-green-500 dark:bg-gray-700 dark:border-gray-600"
                    />
                    <label
                      htmlFor="verified"
                      className="text-sm font-medium text-gray-700 dark:text-gray-300"
                    >
                      Admin Verified
                    </label>
                  </div>
                  <p className="text-xs text-gray-600 dark:text-gray-400 mt-1 ml-7">
                    Mark this item as verified if all stats have been confirmed
                    to match the in-game item
                  </p>
                </div>
              </div>

              {/* Second Column - Slots & Jobs */}
              <div className="space-y-6">
                {/* Slots Section */}
                <div>
                  <h4 className="text-base font-medium text-gray-900 dark:text-gray-100 mb-2 pb-2 border-b border-gray-200 dark:border-gray-700">
                    Equipment Slots *
                  </h4>
                  <p className="text-xs text-gray-600 dark:text-gray-400 mb-3">
                    Select which equipment slots this item can be used in:
                  </p>
                  <div className="grid grid-cols-2 gap-2">
                    {availableSlots.map((slot) => {
                      const isSelected = slotSelectionMap.has(slot);
                      return (
                        <label
                          key={slot}
                          className={`
                            flex items-center space-x-2 p-2 rounded border  transition-colors
                            ${
                              isSelected
                                ? "bg-blue-50 border-blue-300 text-blue-900 dark:bg-blue-900/20 dark:border-blue-600 dark:text-blue-100"
                                : "bg-gray-50 border-gray-300 text-gray-700 hover:bg-gray-100 dark:bg-gray-800 dark:border-gray-600 dark:text-gray-300 dark:hover:bg-gray-700"
                            }
                          `}
                        >
                          <input
                            type="checkbox"
                            checked={isSelected}
                            onChange={() => handleSlotToggle(slot)}
                            className="w-4 h-4 text-blue-600 bg-gray-100 border-gray-300 rounded focus:ring-blue-500 dark:bg-gray-700 dark:border-gray-600"
                          />
                          <span className="text-sm font-medium capitalize">
                            {slot}
                          </span>
                        </label>
                      );
                    })}
                  </div>
                  <div className="mt-2 text-xs text-gray-600 dark:text-gray-400">
                    {formData.selectedSlots.length} slot
                    {formData.selectedSlots.length !== 1 ? "s" : ""} selected
                  </div>
                </div>

                {/* Jobs Section */}
                <div>
                  <h4 className="text-base font-medium text-gray-900 dark:text-gray-100 mb-2 pb-2 border-b border-gray-200 dark:border-gray-700">
                    Job Restrictions
                  </h4>
                  <p className="text-xs text-gray-600 dark:text-gray-400 mb-3">
                    Leave all jobs unselected if ALL jobs can use this item:
                  </p>
                  <div className="grid grid-cols-3 gap-2">
                    {jobs.map((job) => {
                      const isSelected = jobSelectionMap.has(job.abbreviation);
                      return (
                        <label
                          key={job.abbreviation}
                          className={`
                            flex items-center space-x-2 p-2 rounded border  transition-colors
                            ${
                              isSelected
                                ? "bg-green-50 border-green-300 text-green-900 dark:bg-green-900/20 dark:border-green-600 dark:text-green-100"
                                : "bg-gray-50 border-gray-300 text-gray-700 hover:bg-gray-100 dark:bg-gray-800 dark:border-gray-600 dark:text-gray-300 dark:hover:bg-gray-700"
                            }
                          `}
                        >
                          <input
                            type="checkbox"
                            checked={isSelected}
                            onChange={() => handleJobToggle(job.abbreviation)}
                            className="w-4 h-4 text-green-600 bg-gray-100 border-gray-300 rounded focus:ring-green-500 dark:bg-gray-700 dark:border-gray-600"
                          />
                          <span className="text-sm font-medium">
                            {job.abbreviation}
                          </span>
                        </label>
                      );
                    })}
                  </div>
                  <div className="mt-2 text-xs text-gray-600 dark:text-gray-400">
                    {formData.selectedJobs.length === 0
                      ? "Available to ALL jobs"
                      : `${formData.selectedJobs.length} job${
                          formData.selectedJobs.length !== 1 ? "s" : ""
                        } selected`}
                  </div>
                </div>
              </div>

              {/* Third Column - Stats */}
              <div className="space-y-6 flex flex-col min-h-0">
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
                      className="px-2 py-1 text-xs font-medium text-blue-600 border border-blue-600 rounded hover:bg-blue-50 dark:text-blue-400 dark:border-blue-400 dark:hover:bg-blue-900/20 cursor-pointer disabled:cursor-not-allowed"
                    >
                      Add Stat
                    </button>
                  </div>

                  <div className="space-y-3 flex-1 min-h-0 overflow-y-auto pb-6">
                    {formData.stats.map((stat, index) => (
                      <div key={index} className="flex items-center space-x-2">
                        <div className="flex-1">
                          <ReactSelector
                            value={
                              statOptions.find(
                                (option) => option.value === stat.statName
                              ) || null
                            }
                            onChange={(selectedOption) =>
                              handleStatChange(
                                index,
                                "statName",
                                selectedOption?.value || ""
                              )
                            }
                            options={statOptions}
                            placeholder="Select a stat..."
                            isClearable
                            isSearchable
                            menuPlacement="auto"
                            menuPortalTarget={document.body}
                            menuPosition="fixed"
                            styles={{
                              menuPortal: (base) => ({ ...base, zIndex: 9999 }),
                            }}
                          />
                        </div>
                        <div className="w-24">
                          <input
                            type="number"
                            value={stat.value ?? ""}
                            onChange={(e) =>
                              handleStatChange(
                                index,
                                "value",
                                e.target.value === "" ? null : parseInt(e.target.value, 10) || null
                              )
                            }
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
                            <svg
                              className="w-4 h-4"
                              fill="none"
                              stroke="currentColor"
                              viewBox="0 0 24 24"
                            >
                              <path
                                strokeLinecap="round"
                                strokeLinejoin="round"
                                strokeWidth={2}
                                d="M6 18L18 6M6 6l12 12"
                              />
                            </svg>
                          </button>
                        )}
                      </div>
                    ))}
                  </div>
                  <div className="mt-3 text-xs text-gray-600 dark:text-gray-400">
                    {hasValidStats
                      ? `${
                          formData.stats.filter(
                            (s) => s.statName.trim() && s.value !== 0
                          ).length
                        } valid stat${
                          formData.stats.filter(
                            (s) => s.statName.trim() && s.value !== 0
                          ).length !== 1
                            ? "s"
                            : ""
                        } configured`
                      : "At least one stat with a non-zero value is required"}
                  </div>
                </div>
              </div>
            </div>

            {/* Form Actions */}
            <div className="flex justify-between items-center pt-4 border-t border-gray-200 dark:border-gray-700 flex-shrink-0">
              <div className="text-sm text-gray-600 dark:text-gray-400">
                {isFormValid
                  ? `Ready to ${editingItem ? "update" : "create"} gear item`
                  : "Name, at least one slot, and one valid stat required"}
              </div>

              <div className="flex space-x-2">
                <button
                  type="button"
                  onClick={handleClose}
                  disabled={isSubmitting}
                  className="px-4 py-2 text-sm font-medium text-gray-700 bg-gray-100 border border-gray-300 rounded-md hover:bg-gray-200 focus:outline-none focus:ring-2 focus:ring-gray-500 disabled:opacity-50 dark:bg-gray-700 dark:text-gray-300 dark:border-gray-600 dark:hover:bg-gray-600 cursor-pointer disabled:cursor-not-allowed"
                >
                  Cancel
                </button>
                <button
                  type="submit"
                  disabled={!isFormValid || isSubmitting}
                  className="px-4 py-2 text-sm font-medium text-white bg-blue-600 border border-transparent rounded-md hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-500 disabled:opacity-50  cursor-pointer disabled:cursor-not-allowed"
                >
                  {isSubmitting ? (
                    <div className="flex items-center space-x-2">
                      <div className="animate-spin rounded-full h-4 w-4 border-b-2 border-white"></div>
                      <span>{editingItem ? "Updating..." : "Creating..."}</span>
                    </div>
                  ) : editingItem ? (
                    "Update Gear Item"
                  ) : (
                    "Create Gear Item"
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

export default GearItemModal;
