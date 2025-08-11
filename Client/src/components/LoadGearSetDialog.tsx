import { FaFolderOpen } from "react-icons/fa6";
import Modal from "./Modal";
import type { Job } from "../models/Job";
import type { GearSet } from "../models/GearSet";

interface LoadGearSetDialogProps {
  isOpen: boolean;
  job: Job;
  savedGearSets: GearSet[];
  targetSet: "A" | "B";
  isLoading?: boolean;
  onClose: () => void;
  onLoadGearSet: (gearSet: GearSet) => void;
}

export function LoadGearSetDialog({
  isOpen,
  job,
  savedGearSets,
  targetSet,
  isLoading = false,
  onClose,
  onLoadGearSet,
}: LoadGearSetDialogProps) {
  const jobGearSets = savedGearSets.filter((gearSet) => gearSet.jobId === job.id);

  return (
    <Modal isOpen={isOpen} onClose={onClose} size="md">
      <div className="p-6">
        <h3 className="text-lg font-semibold mb-4 text-gray-900 dark:text-white">
          Load Set {targetSet}{" "}
          <span className="text-sm text-blue-500 dark:text-blue-300 ml-2">
            ({job.fullName})
          </span>
        </h3>

        <div className="max-h-96 overflow-y-auto mb-6">
          {jobGearSets.length === 0 ? (
            <div className="text-center py-8">
              <div className="text-gray-400 dark:text-gray-500 mb-2">
                <FaFolderOpen className="h-12 w-12 mx-auto" />
              </div>
              <p className="text-gray-500 dark:text-gray-400">
                No saved gear sets found for {job.fullName}.
              </p>
              <p className="text-sm text-gray-400 dark:text-gray-500 mt-1">
                Save a gear set first to load it later.
              </p>
            </div>
          ) : (
            <div className="space-y-2">
              {jobGearSets.map((gearSet) => (
                <button
                  key={gearSet.id}
                  onClick={() => onLoadGearSet(gearSet)}
                  disabled={isLoading}
                  className={`block w-full text-left p-3 border border-gray-200 dark:border-gray-600 rounded-lg hover:bg-gray-50 dark:hover:bg-gray-700 hover:border-blue-300 dark:hover:border-blue-500 focus:outline-none focus:ring-2 focus:ring-blue-500 transition-colors ${
                    isLoading ? 'opacity-50 cursor-not-allowed' : ''
                  }`}
                >
                  <div className="font-medium text-gray-900 dark:text-white">
                    {gearSet.name}
                  </div>
                  {gearSet.description && (
                    <div className="text-sm text-gray-600 dark:text-gray-300 mt-1">
                      {gearSet.description}
                    </div>
                  )}
                </button>
              ))}
            </div>
          )}
        </div>

        <div className="flex justify-end pt-4 border-t border-gray-200 dark:border-gray-600">
          <button
            onClick={onClose}
            className="px-4 py-2 text-gray-700 dark:text-gray-300 border border-gray-300 dark:border-gray-600 rounded-lg hover:bg-gray-50 dark:hover:bg-gray-700 focus:outline-none focus:ring-2 focus:ring-blue-500 transition-colors"
          >
            Cancel
          </button>
        </div>
      </div>
    </Modal>
  );
}
