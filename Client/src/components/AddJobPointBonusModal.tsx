import { useState, useEffect, useMemo } from "react";
import Modal from "./Modal";
import { ReactSelector } from "./ReactSelector";
import { JobConfigurationsService } from "../services";
import { useAppData } from "../contexts/AppDataContext";
import type { JobPointBonus } from "../models/JobConfiguration";

interface AddJobPointBonusModalProps {
  isOpen: boolean;
  onClose: () => void;
  onJobPointBonusCreated: (newJobPointBonus: JobPointBonus) => void;
  jobConfigurationId: number;
}

interface NewJobPointBonusForm {
  statId: number | null;
  value: number;
}

const AddJobPointBonusModal = ({
  isOpen,
  onClose,
  onJobPointBonusCreated,
  jobConfigurationId,
}: AddJobPointBonusModalProps) => {
  const { stats, loading: loadingAppData } = useAppData();
  const [newJobPointBonusForm, setNewJobPointBonusForm] = useState<NewJobPointBonusForm>({
    statId: null,
    value: 0,
  });
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [hasLoaded, setHasLoaded] = useState(false);

  useEffect(() => {
    if (isOpen && !loadingAppData) {
      setHasLoaded(true);
    } else if (!isOpen) {
      // Reset state when modal closes
      setHasLoaded(false);
    }
  }, [isOpen, loadingAppData]);

  // Memoize stat options for ReactSelector
  const statOptions = useMemo(
    () =>
      stats.map((stat) => ({
        value: stat.id,
        label: stat.displayName || stat.name,
      })),
    [stats]
  );

  const handleAddJobPointBonus = async (e: React.FormEvent) => {
    e.preventDefault();
    
    if (!newJobPointBonusForm.statId) {
      setError("Please select a stat");
      return;
    }

    setIsSubmitting(true);
    setError(null);

    try {
      const newJobPointBonus = await JobConfigurationsService.addJobPointBonus(jobConfigurationId, {
        statId: newJobPointBonusForm.statId,
        value: newJobPointBonusForm.value,
      });

      onJobPointBonusCreated(newJobPointBonus);
      resetForm();
      onClose();
      console.log("Job point bonus created successfully");
    } catch (err) {
      console.error("Error creating job point bonus:", err);
      setError(
        err instanceof Error
          ? err.message
          : "Failed to create job point bonus. Please try again."
      );
    } finally {
      setIsSubmitting(false);
    }
  };

  const handleFormChange = (field: keyof NewJobPointBonusForm, value: string | number | null) => {
    setNewJobPointBonusForm(prev => ({
      ...prev,
      [field]: value,
    }));
    
    // Clear error when user starts typing
    if (error) {
      setError(null);
    }
  };

  const resetForm = () => {
    setNewJobPointBonusForm({
      statId: null,
      value: 0,
    });
    setError(null);
  };

  const handleClose = () => {
    if (!isSubmitting) {
      resetForm();
      onClose();
    }
  };

  if (!isOpen) return null;

  return (
    <Modal isOpen={isOpen} onClose={handleClose} size="md">
      {loadingAppData || !hasLoaded ? (
        <div className="p-4 space-y-6">
          <div>
            <h3 className="text-lg font-semibold text-gray-900 dark:text-gray-100 mb-2">
              Add New Job Point Bonus
            </h3>
            <p className="text-sm text-gray-600 dark:text-gray-400">
              Add a job point bonus to this job configuration. Job point bonuses provide stat improvements from spending job points.
            </p>
          </div>
          
          <div className="flex flex-col items-center justify-center" style={{ minHeight: '250px' }}>
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
              Add New Job Point Bonus
            </h3>
            <p className="text-sm text-gray-600 dark:text-gray-400">
              Add a job point bonus to this job configuration. Job point bonuses provide stat improvements from spending job points.
            </p>
          </div>

          {error && (
            <div className="p-3 bg-red-100 border border-red-400 text-red-700 rounded">
              {error}
            </div>
          )}

          <form
            onSubmit={handleAddJobPointBonus}
            className="space-y-4"
            autoComplete="off"
          >
            {/* Stat Selection */}
            <div>
              <label
                htmlFor="stat-select"
                className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
              >
                Stat *
              </label>
              <ReactSelector
                value={
                  statOptions.find(
                    (option) => option.value === newJobPointBonusForm.statId
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
                  menuPortal: (base) => ({ ...base, zIndex: 9999 })
                }}
              />
              <p className="mt-1 text-xs text-gray-500 dark:text-gray-400">
                Select which stat this job point bonus affects
              </p>
            </div>

            {/* Value */}
            <div>
              <label
                htmlFor="jpb-value"
                className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
              >
                Value *
              </label>
              <input
                id="jpb-value"
                name="job-point-bonus-value"
                type="number"
                min="0"
                max="999"
                value={newJobPointBonusForm.value}
                onChange={(e) => handleFormChange("value", parseInt(e.target.value) || 0)}
                required
                autoComplete="off"
                data-lpignore="true"
                data-form-type="other"
                className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                placeholder="e.g., 5"
                disabled={isSubmitting}
              />
              <p className="mt-1 text-xs text-gray-500 dark:text-gray-400">
                Bonus value provided by this job point bonus
              </p>
            </div>

            <div className="flex justify-between items-center pt-4 border-t border-gray-200 dark:border-gray-700">
              <div className="text-sm text-gray-600 dark:text-gray-400">
                {newJobPointBonusForm.statId 
                  ? "Ready to add job point bonus" 
                  : "Select a stat to continue"}
              </div>

              <div className="flex space-x-2">
                <button
                  type="button"
                  onClick={handleClose}
                  disabled={isSubmitting}
                  className="px-4 py-2 text-sm font-medium text-gray-700 bg-gray-100 border border-gray-300 rounded-md hover:bg-gray-200 focus:outline-none focus:ring-2 focus:ring-gray-500 disabled:opacity-50 dark:bg-gray-700 dark:text-gray-300 dark:border-gray-600 dark:hover:bg-gray-600 cursor-pointer disabled:opacity-50 disabled:cursor-not-allowed"
                >
                  Cancel
                </button>
                <button
                  type="submit"
                  disabled={!newJobPointBonusForm.statId || isSubmitting}
                  className="px-4 py-2 text-sm font-medium text-white bg-blue-600 border border-transparent rounded-md hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-500 cursor-pointer disabled:opacity-50 disabled:cursor-not-allowed"
                >
                  {isSubmitting ? (
                    <div className="flex items-center space-x-2">
                      <div className="animate-spin rounded-full h-4 w-4 border-b-2 border-white"></div>
                      <span>Adding...</span>
                    </div>
                  ) : (
                    "Add Job Point Bonus"
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

export default AddJobPointBonusModal;
