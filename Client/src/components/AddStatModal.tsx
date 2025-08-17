import { useState } from "react";
import Modal from "./Modal";
import { StatsService } from "../services";
import { useAppData } from "../contexts/AppDataContext";
import type { Stat } from "../models/Stat";

interface AddStatModalProps {
  isOpen: boolean;
  onClose: () => void;
  onStatCreated: (newStat: Stat) => void;
}

interface NewStatForm {
  name: string;
  displayName: string;
  category: string;
  description: string;
}

const AddStatModal = ({
  isOpen,
  onClose,
  onStatCreated,
}: AddStatModalProps) => {
  const {
    statCategories: availableStatCategories,
    loading: loadingAppData,
    refreshStats,
  } = useAppData();
  const [newStatForm, setNewStatForm] = useState<NewStatForm>({
    name: "",
    displayName: "",
    category: "",
    description: "",
  });
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [error, setError] = useState<string | null>(null);

  const handleAddStat = async (e: React.FormEvent) => {
    e.preventDefault();
    setIsSubmitting(true);
    setError(null);

    try {
      const newStat = await StatsService.createStat({
        name: newStatForm.name,
        displayName: newStatForm.displayName || undefined,
        category: newStatForm.category || undefined,
        description: newStatForm.description || undefined,
      });

      // Refresh the stats in the context so all components get the updated data
      await refreshStats();

      onStatCreated(newStat);
      resetForm();
      onClose();

      console.log("Stat created successfully");
    } catch (err) {
      console.error("Error creating stat:", err);
      setError(
        err instanceof Error
          ? err.message
          : "Failed to create stat. Please try again."
      );
    } finally {
      setIsSubmitting(false);
    }
  };

  const handleFormChange = (field: keyof NewStatForm, value: string) => {
    setNewStatForm((prev) => ({
      ...prev,
      [field]: value,
    }));
  };

  const handleCategoryChange = (
    event: React.ChangeEvent<HTMLSelectElement>
  ) => {
    const value = event.target.value;
    setNewStatForm((prev) => ({
      ...prev,
      category: value,
    }));
  };

  const resetForm = () => {
    setNewStatForm({
      name: "",
      displayName: "",
      category: "",
      description: "",
    });
    setError(null);
  };

  const handleClose = () => {
    resetForm();
    onClose();
  };

  return (
    <Modal isOpen={isOpen} onClose={handleClose} size="md">
      {loadingAppData ? (
        <div className="p-4 text-center">
          <div className="animate-spin rounded-full h-6 w-6 border-b-2 border-blue-600 mx-auto"></div>
          <p className="mt-2 text-sm text-gray-600 dark:text-gray-400">
            Loading...
          </p>
        </div>
      ) : (
        <div className="p-4 space-y-6">
          <div>
            <h3 className="text-lg font-semibold text-gray-900 dark:text-gray-100 mb-2">
              Add New Stat
            </h3>
            <p className="text-sm text-gray-600 dark:text-gray-400">
              Create a new stat with name, display name, category, and
              description:
            </p>
          </div>

          {error && (
            <div className="p-3 bg-red-100 border border-red-400 text-red-700 rounded">
              {error}
            </div>
          )}

          <form
            onSubmit={handleAddStat}
            className="space-y-4"
            autoComplete="off"
          >
            <div>
              <label
                htmlFor="name"
                className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
              >
                Name *
              </label>
              <input
                type="text"
                id="name"
                name="stat-name"
                value={newStatForm.name}
                onChange={(e) => handleFormChange("name", e.target.value)}
                required
                autoComplete="off"
                data-lpignore="true"
                data-form-type="other"
                className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                placeholder="e.g., STR, Store TP"
              />
            </div>

            <div>
              <label
                htmlFor="displayName"
                className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
              >
                Display Name
              </label>
              <input
                type="text"
                id="displayName"
                name="stat-display-name"
                value={newStatForm.displayName}
                onChange={(e) =>
                  handleFormChange("displayName", e.target.value)
                }
                autoComplete="off"
                data-lpignore="true"
                data-form-type="other"
                className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                placeholder="e.g., Strength"
              />
            </div>

            <div>
              <label
                htmlFor="category"
                className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
              >
                Category
              </label>
              <select
                id="category"
                name="stat-category"
                value={newStatForm.category}
                onChange={handleCategoryChange}
                autoComplete="off"
                data-lpignore="true"
                className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
              >
                <option value="">No Category</option>
                {availableStatCategories.map((category) => (
                  <option key={category} value={category}>
                    {category}
                  </option>
                ))}
              </select>
            </div>

            <div>
              <label
                htmlFor="description"
                className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
              >
                Description
              </label>
              <textarea
                id="description"
                name="stat-description"
                value={newStatForm.description}
                onChange={(e) =>
                  handleFormChange("description", e.target.value)
                }
                rows={3}
                autoComplete="off"
                data-lpignore="true"
                data-form-type="other"
                className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                placeholder="Optional description or tooltip text"
              />
            </div>

            <div className="flex justify-between items-center pt-4 border-t border-gray-200 dark:border-gray-700">
              <div className="text-sm text-gray-600 dark:text-gray-400">
                {newStatForm.name ? "Ready to create stat" : "Name is required"}
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
                  disabled={!newStatForm.name || isSubmitting}
                  className="px-4 py-2 text-sm font-medium text-white bg-blue-600 border border-transparent rounded-md hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-500 cursor-pointer disabled:opacity-50 disabled:cursor-not-allowed"
                >
                  {isSubmitting ? (
                    <div className="flex items-center space-x-2">
                      <div className="animate-spin rounded-full h-4 w-4 border-b-2 border-white"></div>
                      <span>Creating...</span>
                    </div>
                  ) : (
                    "Create Stat"
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

export default AddStatModal;
