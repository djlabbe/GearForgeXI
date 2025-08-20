import { useState, useEffect, useMemo } from "react";
import Modal from "./Modal";
import { ReactSelector } from "./ReactSelector";
import { JobConfigurationsService } from "../services";
import { useAppData } from "../contexts/AppDataContext";
import type { JobTrait } from "../models/JobConfiguration";

interface AddJobTraitModalProps {
  isOpen: boolean;
  onClose: () => void;
  onJobTraitCreated: (newJobTrait: JobTrait) => void;
  jobConfigurationId: number;
}

interface NewJobTraitForm {
  name: string;
  level: number;
  statId: number | null;
  value: number;
}

const AddJobTraitModal = ({
  isOpen,
  onClose,
  onJobTraitCreated,
  jobConfigurationId,
}: AddJobTraitModalProps) => {
  const { stats, loading: loadingAppData } = useAppData();
  const [newJobTraitForm, setNewJobTraitForm] = useState<NewJobTraitForm>({
    name: "",
    level: 1,
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

  const handleAddJobTrait = async (e: React.FormEvent) => {
    e.preventDefault();
    
    if (!newJobTraitForm.statId) {
      setError("Please select a stat");
      return;
    }

    if (!newJobTraitForm.name.trim()) {
      setError("Please enter a trait name");
      return;
    }

    setIsSubmitting(true);
    setError(null);

    try {
      const newJobTrait = await JobConfigurationsService.addJobTrait(jobConfigurationId, {
        name: newJobTraitForm.name.trim(),
        level: newJobTraitForm.level,
        statId: newJobTraitForm.statId,
        value: newJobTraitForm.value,
      });

      onJobTraitCreated(newJobTrait);
      resetForm();
      onClose();
      console.log("Job trait created successfully");
    } catch (err) {
      console.error("Error creating job trait:", err);
      setError(
        err instanceof Error
          ? err.message
          : "Failed to create job trait. Please try again."
      );
    } finally {
      setIsSubmitting(false);
    }
  };

  const handleFormChange = (field: keyof NewJobTraitForm, value: string | number | null) => {
    setNewJobTraitForm(prev => ({
      ...prev,
      [field]: value,
    }));
    
    // Clear error when user starts typing
    if (error) {
      setError(null);
    }
  };

  const resetForm = () => {
    setNewJobTraitForm({
      name: "",
      level: 1,
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
              Add New Job Trait
            </h3>
            <p className="text-sm text-gray-600 dark:text-gray-400">
              Add a trait to this job configuration. Traits are abilities that provide stat bonuses at specific levels.
            </p>
          </div>
          
          <div className="flex flex-col items-center justify-center" style={{ minHeight: '380px' }}>
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
              Add New Job Trait
            </h3>
            <p className="text-sm text-gray-600 dark:text-gray-400">
              Add a trait to this job configuration. Traits are abilities that provide stat bonuses at specific levels.
            </p>
          </div>

          {error && (
            <div className="p-3 bg-red-100 border border-red-400 text-red-700 rounded">
              {error}
            </div>
          )}

          <form
            onSubmit={handleAddJobTrait}
            className="space-y-4"
            autoComplete="off"
          >
            {/* Trait Name */}
            <div>
              <label
                htmlFor="trait-name"
                className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
              >
                Trait Name *
              </label>
              <input
                id="trait-name"
                name="job-trait-name"
                type="text"
                value={newJobTraitForm.name}
                onChange={(e) => handleFormChange("name", e.target.value)}
                required
                autoComplete="off"
                data-lpignore="true"
                data-form-type="other"
                className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                placeholder="e.g., Attack Boost"
                disabled={isSubmitting}
              />
              <p className="mt-1 text-xs text-gray-500 dark:text-gray-400">
                Enter a descriptive name for this trait
              </p>
            </div>

            {/* Level */}
            <div>
              <label
                htmlFor="trait-level"
                className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
              >
                Level *
              </label>
              <input
                id="trait-level"
                name="job-trait-level"
                type="number"
                min="1"
                max="99"
                value={newJobTraitForm.level}
                onChange={(e) => handleFormChange("level", parseInt(e.target.value) || 1)}
                required
                autoComplete="off"
                data-lpignore="true"
                data-form-type="other"
                className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                placeholder="e.g., 10"
                disabled={isSubmitting}
              />
              <p className="mt-1 text-xs text-gray-500 dark:text-gray-400">
                Level when this trait becomes available (1-99)
              </p>
            </div>

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
                    (option) => option.value === newJobTraitForm.statId
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
                Select which stat this trait affects
              </p>
            </div>

            {/* Value */}
            <div>
              <label
                htmlFor="trait-value"
                className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
              >
                Value *
              </label>
              <input
                id="trait-value"
                name="job-trait-value"
                type="number"
                min="-999"
                max="999"
                value={newJobTraitForm.value}
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
                Bonus value provided by this trait
              </p>
            </div>

            <div className="flex justify-between items-center pt-4 border-t border-gray-200 dark:border-gray-700">
              <div className="text-sm text-gray-600 dark:text-gray-400">
                {newJobTraitForm.statId && newJobTraitForm.name.trim() 
                  ? "Ready to add trait" 
                  : "Fill required fields to continue"}
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
                  disabled={!newJobTraitForm.statId || !newJobTraitForm.name.trim() || isSubmitting}
                  className="px-4 py-2 text-sm font-medium text-white bg-blue-600 border border-transparent rounded-md hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-500 cursor-pointer disabled:opacity-50 disabled:cursor-not-allowed"
                >
                  {isSubmitting ? (
                    <div className="flex items-center space-x-2">
                      <div className="animate-spin rounded-full h-4 w-4 border-b-2 border-white"></div>
                      <span>Adding...</span>
                    </div>
                  ) : (
                    "Add Trait"
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

export default AddJobTraitModal;
