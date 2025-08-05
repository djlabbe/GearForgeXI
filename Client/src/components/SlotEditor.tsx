import { useState, useEffect, useCallback, useMemo } from 'react';
import type { GearItem } from '../models/GearItem';
import { useSlots } from '../contexts/SlotsContext';
import ApiService from '../utils/apiService';

interface SlotEditorProps {
  item: GearItem;
  onUpdate: (updatedItem: GearItem) => void;
  onCancel: () => void;
  onClose?: () => void;
}

const SlotEditor = ({ item, onUpdate, onCancel, onClose }: SlotEditorProps) => {
  const { slots: availableSlots, loading: slotsLoading } = useSlots();

  const [selectedSlots, setSelectedSlots] = useState<string[]>(item.slots);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    setSelectedSlots(item.slots);
  }, [item.slots]);

  const handleSlotToggle = useCallback((slot: string) => {
    setSelectedSlots(prev => {
      const isCurrentlySelected = prev.includes(slot);
      
      if (isCurrentlySelected) {
        // If currently selected, remove it
        return prev.filter(s => s !== slot);
      } else {
        // Special case: Main and Sub can be selected together
        if (slot === 'Main' || slot === 'Sub') {
          const hasMain = prev.includes('Main');
          const hasSub = prev.includes('Sub');
          
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
    });
  }, []);

  // Memoize slot selection state for better performance
  const slotSelectionMap = useMemo(() => {
    const map = new Set(selectedSlots);
    return map;
  }, [selectedSlots]);

  const handleSave = async () => {
    try {
      setLoading(true);
      setError(null);
      
      await ApiService.updateGearItemSlots(item.id, selectedSlots);
      
      // Update the item with new slots
      const updatedItem: GearItem = {
        ...item,
        slots: selectedSlots
      };
      
      onUpdate(updatedItem);
      onClose?.();
    } catch (err) {
      setError(err instanceof Error ? err.message : 'Failed to update slots');
    } finally {
      setLoading(false);
    }
  };

  const handleCancel = () => {
    setSelectedSlots(item.slots);
    setError(null);
    onCancel();
  };

  if (slotsLoading) {
    return (
      <div className="p-4 text-center">
        <div className="animate-spin rounded-full h-6 w-6 border-b-2 border-blue-600 mx-auto"></div>
        <p className="mt-2 text-sm text-gray-600 dark:text-gray-400">Loading slots...</p>
      </div>
    );
  }

  return (
    <div className="p-4 space-y-4">
      <div>
        <h3 className="text-lg font-semibold text-gray-900 dark:text-gray-100 mb-2">
          Edit Slots for {item.name}
        </h3>
        <p className="text-sm text-gray-600 dark:text-gray-400">
          Select which equipment slots this item can be used in:
        </p>
      </div>

      {error && (
        <div className="p-3 bg-red-100 border border-red-400 text-red-700 rounded">
          {error}
        </div>
      )}

      <div className="grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 gap-2">
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

      <div className="flex justify-between items-center pt-4 border-t border-gray-200 dark:border-gray-700">
        <div className="text-sm text-gray-600 dark:text-gray-400">
          {selectedSlots.length} slot{selectedSlots.length !== 1 ? 's' : ''} selected
        </div>
        
        <div className="flex space-x-2">
          <button
            onClick={handleCancel}
            disabled={loading}
            className="px-4 py-2 text-sm font-medium text-gray-700 bg-gray-100 border border-gray-300 rounded-md hover:bg-gray-200 focus:outline-none focus:ring-2 focus:ring-gray-500 disabled:opacity-50 dark:bg-gray-700 dark:text-gray-300 dark:border-gray-600 dark:hover:bg-gray-600 cursor-pointer"
          >
            Cancel
          </button>
          <button
            onClick={handleSave}
            disabled={loading || selectedSlots.length === 0}
            className="px-4 py-2 text-sm font-medium text-white bg-blue-600 border border-transparent rounded-md hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-500 disabled:opacity-50 cursor-pointer"
          >
            {loading ? (
              <div className="flex items-center space-x-2">
                <div className="animate-spin rounded-full h-4 w-4 border-b-2 border-white"></div>
                <span>Saving...</span>
              </div>
            ) : (
              'Save Changes'
            )}
          </button>
        </div>
      </div>
    </div>
  );
};

export default SlotEditor;
