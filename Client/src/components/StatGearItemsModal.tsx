import { useState, useEffect } from "react";
import Modal from "./Modal";
import ApiService from "../utils/apiService";
import type { GearItem } from "../models/GearItem";
import type { Stat } from "../models/Stat";

interface StatGearItemsModalProps {
  isOpen: boolean;
  onClose: () => void;
  stat: Stat | null;
}

const StatGearItemsModal = ({ isOpen, onClose, stat }: StatGearItemsModalProps) => {
  const [gearItems, setGearItems] = useState<GearItem[]>([]);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    if (isOpen && stat) {
      fetchGearItems();
    }
  }, [isOpen, stat]);

  const fetchGearItems = async () => {
    if (!stat) return;
    
    setLoading(true);
    setError(null);
    
    try {
      const items = await ApiService.getGearItemsByStat(stat.id);
      setGearItems(items);
    } catch (error) {
      console.error("Error fetching gear items:", error);
      setError("Failed to load gear items. Please try again.");
    } finally {
      setLoading(false);
    }
  };

  return (
    <Modal isOpen={isOpen} onClose={onClose} size="xl">
      <div className="p-6">
        <div className="mb-4">
          <h2 className="text-2xl font-bold text-gray-900 dark:text-white">
            Items with {stat?.displayName || stat?.name}
          </h2>
          <p className="text-sm text-gray-600 dark:text-gray-400 mt-1">
            Showing all items that have the "{stat?.displayName || stat?.name}" stat
          </p>
        </div>

        {loading && (
          <div className="flex items-center justify-center py-8">
            <div className="text-gray-600 dark:text-gray-400">Loading items...</div>
          </div>
        )}

        {error && (
          <div className="bg-red-50 dark:bg-red-900/20 border border-red-200 dark:border-red-800 rounded-md p-4 mb-4">
            <div className="text-red-800 dark:text-red-200">{error}</div>
          </div>
        )}

        {!loading && !error && gearItems.length === 0 && (
          <div className="text-center py-8">
            <div className="text-gray-500 dark:text-gray-400">
              No items found with this stat.
            </div>
          </div>
        )}

        {!loading && !error && gearItems.length > 0 && (
          <div className="space-y-4">
            <div className="text-sm text-gray-600 dark:text-gray-400 mb-4">
              Found {gearItems.length} item{gearItems.length !== 1 ? 's' : ''}
            </div>
            
            <div className="max-h-96 overflow-y-auto">
              <div className="grid gap-3">
                {gearItems.map((item) => (
                  <div
                    key={item.id}
                    className="border border-gray-200 dark:border-gray-700 rounded-lg p-4 bg-gray-50 dark:bg-gray-700/50"
                  >
                    <div className="flex items-start justify-between">
                      <div className="flex-1">
                        <h3 className="font-semibold text-gray-900 dark:text-white">
                          {item.name}
                          {item.rank && (
                            <span className="ml-2 text-sm text-blue-600 dark:text-blue-400">
                              Rank {item.rank}
                            </span>
                          )}
                          {item.path && (
                            <span className="ml-1 text-sm text-purple-600 dark:text-purple-400">
                              Path {item.path}
                            </span>
                          )}
                        </h3>
                      </div>
                      
                      <div className="flex items-center ml-4">
                        {item.verified ? (
                          <span className="inline-flex items-center px-2 py-1 rounded-full text-xs font-medium bg-green-100 text-green-800 dark:bg-green-900 dark:text-green-200">
                            Verified
                          </span>
                        ) : (
                          <span className="inline-flex items-center px-2 py-1 rounded-full text-xs font-medium bg-yellow-100 text-yellow-800 dark:bg-yellow-900 dark:text-yellow-200">
                            Unverified
                          </span>
                        )}
                      </div>
                    </div>
                  </div>
                ))}
              </div>
            </div>
          </div>
        )}

        <div className="mt-6 flex justify-end">
          <button
            onClick={onClose}
            className="px-4 py-2 text-gray-700 dark:text-gray-300 hover:text-gray-900 dark:hover:text-white transition-colors duration-200 font-medium cursor-pointer disabled:opacity-50 disabled:cursor-not-allowed"
          >
            Close
          </button>
        </div>
      </div>
    </Modal>
  );
};

export default StatGearItemsModal;
