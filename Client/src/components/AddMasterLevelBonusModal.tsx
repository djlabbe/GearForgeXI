import { useState, useEffect, useMemo } from "react";
import Modal from "./Modal";
import { ReactSelector } from "./ReactSelector";
import { JobConfigurationsService } from "../services";
import { useAppData } from "../contexts/AppDataContext";
import type { MasterLevelBonus } from "../models/JobConfiguration";

interface AddMasterLevelBonusModalProps {
  isOpen: boolean;
  onClose: () => void;
  onMasterLevelBonusCreated: (newMasterLevelBonus: MasterLevelBonus) => void;
  jobConfigurationId: number;
  existingStatIds?: number[];
}

interface NewMasterLevelBonusForm {
  statId: number | null;
  value: number;
}

const AddMasterLevelBonusModal = ({
  isOpen,
  onClose,
  onMasterLevelBonusCreated,
  jobConfigurationId,
  existingStatIds = [],
}: AddMasterLevelBonusModalProps) => {
  const { stats, loading: loadingAppData } = useAppData();
  const [newMasterLevelBonusForm, setNewMasterLevelBonusForm] =
    useState<NewMasterLevelBonusForm>({
      statId: null,
      value: 0,
    });
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [hasLoaded, setHasLoaded] = useState(false);

  // Filter stats to only include those that aren't already used
  const availableStats = useMemo(() => {
    return stats.filter((stat) => !existingStatIds.includes(stat.id));
  }, [stats, existingStatIds]);

  // Memoize stat options for ReactSelector
  const statOptions = useMemo(
    () =>
      availableStats.map((stat) => ({
        value: stat.id,
        label: stat.displayName || stat.name,
      })),
    [availableStats]
  );

  useEffect(() => {
    if (isOpen && !loadingAppData && stats.length > 0) {
      setHasLoaded(false);
      // Auto-select first available stat if there's only one and no stat is currently selected
      if (availableStats.length === 1 && !newMasterLevelBonusForm.statId) {
        setNewMasterLevelBonusForm((prev) => ({
          ...prev,
          statId: availableStats[0].id,
        }));
      }
      setHasLoaded(true);
    } else if (isOpen && !loadingAppData) {
      // Stats are loaded but empty, still consider it loaded
      setHasLoaded(true);
    } else if (!isOpen) {
      // Reset state when modal closes
      setHasLoaded(false);
    }
  }, [
    isOpen,
    loadingAppData,
    stats,
    availableStats,
    newMasterLevelBonusForm.statId,
  ]);

  const handleAddMasterLevelBonus = async (e: React.FormEvent) => {
    e.preventDefault();

    if (!newMasterLevelBonusForm.statId) {
      setError("Please select a stat");
      return;
    }

    setIsSubmitting(true);
    setError(null);

    try {
      const newMasterLevelBonus =
        await JobConfigurationsService.addMasterLevelBonus(jobConfigurationId, {
          statId: newMasterLevelBonusForm.statId,
          value: newMasterLevelBonusForm.value,
        });

      onMasterLevelBonusCreated(newMasterLevelBonus);
      resetForm();
      onClose();
      console.log("Master level bonus created successfully");
    } catch (err) {
      console.error("Error creating master level bonus:", err);
      setError(
        err instanceof Error
          ? err.message
          : "Failed to create master level bonus. Please try again."
      );
    } finally {
      setIsSubmitting(false);
    }
  };

  const handleFormChange = (
    field: keyof NewMasterLevelBonusForm,
    value: number | null
  ) => {
    setNewMasterLevelBonusForm((prev) => ({
      ...prev,
      [field]: value,
    }));
  };

  const resetForm = () => {
    setNewMasterLevelBonusForm({
      statId: null,
      value: 0,
    });
    setError(null);
  };

  const handleClose = () => {
    resetForm();
    onClose();
  };

  return (
    <Modal isOpen={isOpen} onClose={handleClose} size="md">
      {loadingAppData || !hasLoaded ? (
        <div className="p-4 space-y-6">
          <div>
            <h3 className="text-lg font-semibold text-gray-900 dark:text-gray-100 mb-2">
              Add New Master Level Bonus
            </h3>
            <p className="text-sm text-gray-600 dark:text-gray-400">
              Add a master level bonus to this job configuration.
            </p>
          </div>

          <div
            className="flex flex-col items-center justify-center"
            style={{ minHeight: "280px" }}
          >
            <div className="animate-spin rounded-full h-8 w-8 border-b-2 border-blue-600 mx-auto"></div>
            <p className="mt-4 text-sm text-gray-600 dark:text-gray-400">
              Loading stats...
            </p>
          </div>
        </div>
      ) : (
        <div className="p-4 space-y-6">
          <div>
            <h3 className="text-lg font-semibold text-gray-900 dark:text-gray-100 mb-2">
              Add New Master Level Bonus
            </h3>
            <p className="text-sm text-gray-600 dark:text-gray-400">
              Add a master level bonus to this job configuration.
            </p>
          </div>

          {error && (
            <div className="p-3 bg-red-100 border border-red-400 text-red-700 rounded">
              {error}
            </div>
          )}

          {availableStats.length === 0 ? (
            <div className="text-center py-6">
              <div className="text-gray-500 dark:text-gray-400">
                <svg
                  className="mx-auto h-12 w-12 text-gray-400"
                  fill="none"
                  viewBox="0 0 24 24"
                  stroke="currentColor"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    strokeWidth={2}
                    d="M9 19v-6a2 2 0 00-2-2H5a2 2 0 00-2 2v6a2 2 0 002 2h2a2 2 0 002-2zm0 0V9a2 2 0 012-2h2a2 2 0 012 2v10m-6 0a2 2 0 002 2h2a2 2 0 002-2m0 0V5a2 2 0 012-2h2a2 2 0 012 2v14a2 2 0 01-2 2h-2a2 2 0 01-2-2z"
                  />
                </svg>
                <h3 className="mt-2 text-sm font-medium text-gray-900 dark:text-gray-300">
                  No available stats
                </h3>
                <p className="mt-1 text-sm text-gray-500 dark:text-gray-400">
                  All stats have already been added to this job configuration.
                </p>
              </div>
            </div>
          ) : (
            <form
              onSubmit={handleAddMasterLevelBonus}
              className="space-y-4"
              autoComplete="off"
            >
              <div>
                <label className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2">
                  Stat *
                </label>
                <ReactSelector
                  value={
                    statOptions.find(
                      (option) =>
                        option.value === newMasterLevelBonusForm.statId
                    ) || null
                  }
                  onChange={(selectedOption) =>
                    handleFormChange("statId", selectedOption?.value || null)
                  }
                  options={statOptions}
                  placeholder="Choose a stat..."
                  isClearable
                  isSearchable
                  menuPlacement="auto"
                  menuPortalTarget={document.body}
                  isDisabled={isSubmitting}
                  styles={{
                    menuPortal: (base) => ({ ...base, zIndex: 9999 }),
                  }}
                />
              </div>

              <div>
                <label
                  htmlFor="value"
                  className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
                >
                  Value *
                </label>
                <input
                  type="number"
                  id="value"
                  name="master-level-bonus-value"
                  value={newMasterLevelBonusForm.value}
                  onChange={(e) =>
                    handleFormChange("value", parseInt(e.target.value) || 0)
                  }
                  required
                  min="0"
                  max="50"
                  autoComplete="off"
                  data-lpignore="true"
                  data-form-type="other"
                  className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                  placeholder="e.g., 1"
                />
                <p className="mt-1 text-xs text-gray-500 dark:text-gray-400">
                  Enter the stat bonus gained per master level.
                </p>
              </div>

              <div className="flex justify-between items-center pt-4 border-t border-gray-200 dark:border-gray-700">
                <div className="text-sm text-gray-600 dark:text-gray-400">
                  {newMasterLevelBonusForm.statId
                    ? "Ready to add master level bonus"
                    : "Select a stat to continue"}
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
                    disabled={!newMasterLevelBonusForm.statId || isSubmitting}
                    className="px-4 py-2 text-sm font-medium text-white bg-blue-600 border border-transparent rounded-md hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-500 cursor-pointer disabled:opacity-50 disabled:cursor-not-allowed"
                  >
                    {isSubmitting ? (
                      <div className="flex items-center space-x-2">
                        <div className="animate-spin rounded-full h-4 w-4 border-b-2 border-white"></div>
                        <span>Adding...</span>
                      </div>
                    ) : (
                      "Add Master Level Bonus"
                    )}
                  </button>
                </div>
              </div>
            </form>
          )}
        </div>
      )}
    </Modal>
  );
};

export default AddMasterLevelBonusModal;
