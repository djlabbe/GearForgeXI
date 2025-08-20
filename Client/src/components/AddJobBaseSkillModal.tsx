import { useState, useEffect, useMemo } from "react";
import Modal from "./Modal";
import { ReactSelector } from "./ReactSelector";
import { JobConfigurationsService } from "../services";
import { useAppData } from "../contexts/AppDataContext";
import type { JobBaseSkill } from "../models/JobConfiguration";

interface AddJobBaseSkillModalProps {
  isOpen: boolean;
  onClose: () => void;
  onJobBaseSkillCreated: (newJobBaseSkill: JobBaseSkill) => void;
  jobConfigurationId: number;
  existingStatIds?: number[];
}

interface NewJobBaseSkillForm {
  statId: number | null;
  value: number;
}

const AddJobBaseSkillModal = ({
  isOpen,
  onClose,
  onJobBaseSkillCreated,
  jobConfigurationId,
  existingStatIds = [],
}: AddJobBaseSkillModalProps) => {
  const { stats, loading: loadingAppData } = useAppData();
  const [newJobBaseSkillForm, setNewJobBaseSkillForm] =
    useState<NewJobBaseSkillForm>({
      statId: null,
      value: 0,
    });
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [hasLoaded, setHasLoaded] = useState(false);

  // Filter stats to only include skill stats that aren't already used
  const availableBaseSkills = useMemo(() => {
    return stats.filter(
      (stat) => stat.category === "Skill" && !existingStatIds.includes(stat.id)
    );
  }, [stats, existingStatIds]);

  // Memoize stat options for ReactSelector
  const statOptions = useMemo(
    () =>
      availableBaseSkills.map((stat) => ({
        value: stat.id,
        label: stat.displayName || stat.name,
      })),
    [availableBaseSkills]
  );

  useEffect(() => {
    if (isOpen && !loadingAppData) {
      setHasLoaded(true);
    } else if (!isOpen) {
      // Reset state when modal closes
      setHasLoaded(false);
    }
  }, [isOpen, loadingAppData]);

  const handleAddJobBaseSkill = async (e: React.FormEvent) => {
    e.preventDefault();

    if (!newJobBaseSkillForm.statId) {
      setError("Please select a skill");
      return;
    }

    setIsSubmitting(true);
    setError(null);

    try {
      const newJobBaseSkill = await JobConfigurationsService.addJobBaseSkill(
        jobConfigurationId,
        {
          statId: newJobBaseSkillForm.statId,
          value: newJobBaseSkillForm.value,
        }
      );

      onJobBaseSkillCreated(newJobBaseSkill);
      resetForm();
      onClose();
      console.log("Job base skill created successfully");
    } catch (err) {
      console.error("Error creating job base skill:", err);
      setError(
        err instanceof Error
          ? err.message
          : "Failed to create job base skill. Please try again."
      );
    } finally {
      setIsSubmitting(false);
    }
  };

  const handleFormChange = (
    field: keyof NewJobBaseSkillForm,
    value: string | number | null
  ) => {
    setNewJobBaseSkillForm((prev) => ({
      ...prev,
      [field]: value,
    }));

    // Clear error when user starts typing
    if (error) {
      setError(null);
    }
  };

  const resetForm = () => {
    setNewJobBaseSkillForm({
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
              Add New Base Skill
            </h3>
            <p className="text-sm text-gray-600 dark:text-gray-400">
              Add a base skill value to this job configuration. Skills include
              weapon skills, magic skills, and other job-specific abilities.
            </p>
          </div>

          <div
            className="flex flex-col items-center justify-center"
            style={{ minHeight: "280px" }}
          >
            <div className="animate-spin rounded-full h-8 w-8 border-b-2 border-blue-600 mx-auto"></div>
            <p className="mt-4 text-sm text-gray-600 dark:text-gray-400">
              Loading base skills...
            </p>
          </div>
        </div>
      ) : (
        <div className="p-4 space-y-6">
          <div>
            <h3 className="text-lg font-semibold text-gray-900 dark:text-gray-100 mb-2">
              Add New Base Skill
            </h3>
            <p className="text-sm text-gray-600 dark:text-gray-400">
              Add a base skill value to this job configuration. Skills include
              weapon skills, magic skills, and other job-specific abilities.
            </p>
          </div>

          {error && (
            <div className="p-3 bg-red-100 border border-red-400 text-red-700 rounded">
              {error}
            </div>
          )}

          {availableBaseSkills.length === 0 ? (
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
                  No available base skills
                </h3>
                <p className="mt-1 text-sm text-gray-500 dark:text-gray-400">
                  All base skills have already been added to this job
                  configuration.
                </p>
              </div>
            </div>
          ) : (
            <form
              onSubmit={handleAddJobBaseSkill}
              className="space-y-4"
              autoComplete="off"
            >
              <div>
                <label
                  htmlFor="stat-select"
                  className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
                >
                  Base Skill *
                </label>
                <ReactSelector
                  value={
                    statOptions.find(
                      (option) => option.value === newJobBaseSkillForm.statId
                    ) || null
                  }
                  onChange={(selectedOption) =>
                    handleFormChange("statId", selectedOption?.value || null)
                  }
                  options={statOptions}
                  placeholder="Choose a base skill..."
                  isClearable
                  isSearchable
                  menuPlacement="auto"
                  menuPortalTarget={document.body}
                  isDisabled={isSubmitting}
                  styles={{
                    menuPortal: (base) => ({ ...base, zIndex: 9999 }),
                  }}
                />
                <p className="mt-1 text-xs text-gray-500 dark:text-gray-400">
                  Select which base skill to configure for this job
                </p>
              </div>

              <div>
                <label
                  htmlFor="value"
                  className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
                >
                  Base Value *
                </label>
                <input
                  type="number"
                  id="value"
                  name="job-base-skill-value"
                  value={newJobBaseSkillForm.value}
                  onChange={(e) =>
                    handleFormChange("value", parseInt(e.target.value) || 0)
                  }
                  required
                  min="0"
                  max="999"
                  autoComplete="off"
                  data-lpignore="true"
                  data-form-type="other"
                  className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                  placeholder="e.g., 275"
                />
                <p className="mt-1 text-xs text-gray-500 dark:text-gray-400">
                  Enter the base skill value at level 99
                </p>
              </div>

              <div className="flex justify-between items-center pt-4 border-t border-gray-200 dark:border-gray-700">
                <div className="text-sm text-gray-600 dark:text-gray-400">
                  {newJobBaseSkillForm.statId
                    ? "Ready to add base skill"
                    : "Select a skill to continue"}
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
                    disabled={!newJobBaseSkillForm.statId || isSubmitting}
                    className="px-4 py-2 text-sm font-medium text-white bg-blue-600 border border-transparent rounded-md hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-500 cursor-pointer disabled:opacity-50 disabled:cursor-not-allowed"
                  >
                    {isSubmitting ? (
                      <div className="flex items-center space-x-2">
                        <div className="animate-spin rounded-full h-4 w-4 border-b-2 border-white"></div>
                        <span>Adding...</span>
                      </div>
                    ) : (
                      "Add Base Skill"
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

export default AddJobBaseSkillModal;
