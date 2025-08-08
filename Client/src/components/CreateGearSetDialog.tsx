import { useState } from "react";
import Modal from "./Modal";
import type { Job } from "../models/Job";

interface CreateGearSetDialogProps {
  isOpen: boolean;
  job: Job;
  isCreatingSet: boolean;
  onClose: () => void;
  onCreateSet: (setName: string) => void;
}

export function CreateGearSetDialog({
  isOpen,
  job,
  isCreatingSet,
  onClose,
  onCreateSet,
}: CreateGearSetDialogProps) {
  const [customSetName, setCustomSetName] = useState("");

  const handleClose = () => {
    setCustomSetName("");
    onClose();
  };

  const handleCreate = () => {
    onCreateSet(customSetName.trim());
    setCustomSetName("");
  };

  return (
    <Modal isOpen={isOpen} onClose={handleClose} size="md">
      <div className="p-6">
        <h3 className="text-lg font-semibold mb-4 text-gray-900 dark:text-white">
          Create New Gear Set{" "}
          <span className="text-sm text-blue-500 dark:text-blue-300 ml-2">
            ({job.fullName})
          </span>
        </h3>

        <div className="mb-6">
          <label className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2">
            Gear Set Name
          </label>
          <input
            type="text"
            value={customSetName}
            onChange={(e) => setCustomSetName(e.target.value)}
            placeholder={`e.g. ${job.abbreviation} Savage Blade Set`}
            className="w-full px-3 py-2 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-blue-500 bg-white dark:bg-gray-800 text-gray-900 dark:text-white"
            autoFocus
          />
        </div>

        <div className="flex justify-end gap-3 pt-4 border-t border-gray-200 dark:border-gray-600">
          <button
            onClick={handleClose}
            disabled={isCreatingSet}
            className="px-4 py-2 text-gray-700 dark:text-gray-300 border border-gray-300 dark:border-gray-600 rounded-lg hover:bg-gray-50 dark:hover:bg-gray-700 focus:outline-none focus:ring-2 focus:ring-blue-500 transition-colors disabled:opacity-50 disabled:cursor-not-allowed"
          >
            Cancel
          </button>
          <button
            onClick={handleCreate}
            disabled={isCreatingSet}
            className="px-4 py-2 bg-blue-600 text-white rounded-lg hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-500 focus:ring-offset-2 transition-colors disabled:opacity-50 disabled:cursor-not-allowed"
          >
            {isCreatingSet ? (
              <span className="flex items-center">
                <svg
                  className="animate-spin -ml-1 mr-2 h-4 w-4 text-white"
                  xmlns="http://www.w3.org/2000/svg"
                  fill="none"
                  viewBox="0 0 24 24"
                >
                  <circle
                    className="opacity-25"
                    cx="12"
                    cy="12"
                    r="10"
                    stroke="currentColor"
                    strokeWidth="4"
                  ></circle>
                  <path
                    className="opacity-75"
                    fill="currentColor"
                    d="M4 12a8 8 0 018-8V0C5.373 0 0 5.373 0 12h4zm2 5.291A7.962 7.962 0 014 12H0c0 3.042 1.135 5.824 3 7.938l3-2.647z"
                  ></path>
                </svg>
                Creating...
              </span>
            ) : (
              "Create Gear Set"
            )}
          </button>
        </div>
      </div>
    </Modal>
  );
}
