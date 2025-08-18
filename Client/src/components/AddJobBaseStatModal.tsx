import { useState, useEffect } from "react";
import Modal from "./Modal";
import { JobConfigurationsService, StatsService } from "../services";
import type { JobBaseStat } from "../models/JobConfiguration";
import type { Stat } from "../models/Stat";

interface AddJobBaseStatModalProps {
  isOpen: boolean;
  onClose: () => void;
  onJobBaseStatCreated: (newJobBaseStat: JobBaseStat) => void;
  jobConfigurationId: number;
  existingStatIds?: number[];
}

interface NewJobBaseStatForm {
  statId: number | null;
  value: number;
}

const AddJobBaseStatModal = ({
  isOpen,
  onClose,
  onJobBaseStatCreated,
  jobConfigurationId,
  existingStatIds = [],
}: AddJobBaseStatModalProps) => {
  const [baseStats, setBaseStats] = useState<Stat[]>([]);
  const [newJobBaseStatForm, setNewJobBaseStatForm] = useState<NewJobBaseStatForm>({
    statId: null,
    value: 0,
  });
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    if (isOpen) {
      loadBaseStats();
    }
  }, [isOpen]);

  const loadBaseStats = async () => {
    try {
      setLoading(true);
      setError(null);
      const allBaseStats = await StatsService.getBaseStats();
      // Filter out stats that already exist for this job configuration
      const availableStats = allBaseStats.filter(stat => !existingStatIds.includes(stat.id));
      setBaseStats(availableStats);
      
      // Auto-select first available stat if there's only one
      if (availableStats.length === 1) {
        setNewJobBaseStatForm(prev => ({ ...prev, statId: availableStats[0].id }));
      }
    } catch (err) {
      console.error("Error loading base stats:", err);
      setError(
        err instanceof Error
          ? err.message
          : "Failed to load base stats. Please try again."
      );
    } finally {
      setLoading(false);
    }
  };

  const handleAddJobBaseStat = async (e: React.FormEvent) => {
    e.preventDefault();
    
    if (!newJobBaseStatForm.statId) {
      setError("Please select a stat");
      return;
    }

    setIsSubmitting(true);
    setError(null);

    try {
      const newJobBaseStat = await JobConfigurationsService.addJobBaseStat(jobConfigurationId, {
        statId: newJobBaseStatForm.statId,
        value: newJobBaseStatForm.value,
      });

      onJobBaseStatCreated(newJobBaseStat);
      resetForm();
      onClose();
      console.log("Job base stat created successfully");
    } catch (err) {
      console.error("Error creating job base stat:", err);
      setError(
        err instanceof Error
          ? err.message
          : "Failed to create job base stat. Please try again."
      );
    } finally {
      setIsSubmitting(false);
    }
  };

  const handleFormChange = (field: keyof NewJobBaseStatForm, value: number) => {
    setNewJobBaseStatForm((prev) => ({
      ...prev,
      [field]: value,
    }));
  };

  const handleStatChange = (event: React.ChangeEvent<HTMLSelectElement>) => {
    const statId = parseInt(event.target.value);
    setNewJobBaseStatForm((prev) => ({
      ...prev,
      statId: statId || null,
    }));
  };

  const resetForm = () => {
    setNewJobBaseStatForm({
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
      {loading ? (
        <div className="p-4 text-center">
          <div className="animate-spin rounded-full h-6 w-6 border-b-2 border-blue-600 mx-auto"></div>
          <p className="mt-2 text-sm text-gray-600 dark:text-gray-400">
            Loading base stats...
          </p>
        </div>
      ) : (
        <div className="p-4 space-y-6">
          <div>
            <h3 className="text-lg font-semibold text-gray-900 dark:text-gray-100 mb-2">
              Add New Base Stat
            </h3>
            <p className="text-sm text-gray-600 dark:text-gray-400">
              Add a base stat value to this job configuration. Base stats include STR, DEX, VIT, AGI, INT, MND, and CHR.
            </p>
          </div>

          {error && (
            <div className="p-3 bg-red-100 border border-red-400 text-red-700 rounded">
              {error}
            </div>
          )}

          {baseStats.length === 0 ? (
            <div className="text-center py-6">
              <div className="text-gray-500 dark:text-gray-400">
                <svg className="mx-auto h-12 w-12 text-gray-400" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                  <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M9 19v-6a2 2 0 00-2-2H5a2 2 0 00-2 2v6a2 2 0 002 2h2a2 2 0 002-2zm0 0V9a2 2 0 012-2h2a2 2 0 012 2v10m-6 0a2 2 0 002 2h2a2 2 0 002-2m0 0V5a2 2 0 012-2h2a2 2 0 012 2v14a2 2 0 01-2 2h-2a2 2 0 01-2-2z" />
                </svg>
                <h3 className="mt-2 text-sm font-medium text-gray-900 dark:text-gray-300">No available base stats</h3>
                <p className="mt-1 text-sm text-gray-500 dark:text-gray-400">
                  All base stats have already been added to this job configuration.
                </p>
              </div>
            </div>
          ) : (
            <form
              onSubmit={handleAddJobBaseStat}
              className="space-y-4"
              autoComplete="off"
            >
              <div>
                <label
                  htmlFor="stat-select"
                  className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
                >
                  Base Stat *
                </label>
                <select
                  id="stat-select"
                  name="job-base-stat-stat"
                  value={newJobBaseStatForm.statId || ""}
                  onChange={handleStatChange}
                  required
                  autoComplete="off"
                  data-lpignore="true"
                  className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                >
                  <option value="">Choose a base stat...</option>
                  {baseStats.map((stat) => (
                    <option key={stat.id} value={stat.id}>
                      {stat.displayName || stat.name}
                    </option>
                  ))}
                </select>
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
                  name="job-base-stat-value"
                  value={newJobBaseStatForm.value}
                  onChange={(e) => handleFormChange("value", parseInt(e.target.value) || 0)}
                  required
                  min="0"
                  max="999"
                  autoComplete="off"
                  data-lpignore="true"
                  data-form-type="other"
                  className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                  placeholder="e.g., 37"
                />
                <p className="mt-1 text-xs text-gray-500 dark:text-gray-400">
                  Enter the base stat value at level 99
                </p>
              </div>

              <div className="flex justify-between items-center pt-4 border-t border-gray-200 dark:border-gray-700">
                <div className="text-sm text-gray-600 dark:text-gray-400">
                  {newJobBaseStatForm.statId ? "Ready to add base stat" : "Select a stat to continue"}
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
                    disabled={!newJobBaseStatForm.statId || isSubmitting}
                    className="px-4 py-2 text-sm font-medium text-white bg-blue-600 border border-transparent rounded-md hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-500 cursor-pointer disabled:opacity-50 disabled:cursor-not-allowed"
                  >
                    {isSubmitting ? (
                      <div className="flex items-center space-x-2">
                        <div className="animate-spin rounded-full h-4 w-4 border-b-2 border-white"></div>
                        <span>Adding...</span>
                      </div>
                    ) : (
                      "Add Base Stat"
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

export default AddJobBaseStatModal;
