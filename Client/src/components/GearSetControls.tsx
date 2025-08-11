import {
  FaCopy,
  FaFloppyDisk,
  FaFolderOpen,
  FaPlus,
} from "react-icons/fa6";
import type { GearSet } from "../models/GearSet";
import type { GearStat } from "../models/GearStat";
import { RiResetLeftFill } from "react-icons/ri";

// Loading spinner component
const LoadingSpinner = () => (
  <svg className="animate-spin h-5 w-5" fill="none" viewBox="0 0 24 24">
    <circle
      className="opacity-25"
      cx="12"
      cy="12"
      r="10"
      stroke="currentColor"
      strokeWidth="4"
    />
    <path
      className="opacity-75"
      fill="currentColor"
      d="m4 12a8 8 0 018-8V0C5.373 0 0 5.373 0 12h4zm2 5.291A7.962 7.962 0 014 12H0c0 3.042 1.135 5.824 3 7.938l3-2.647z"
    />
  </svg>
);

interface GearSetControlsProps {
  gearSet: GearSet;
  augments: GearStat[];
  isAuthenticated: boolean;
  isCreating?: boolean;
  isUpdating?: boolean;
  isLoading?: boolean;
  onCreateNew: () => void;
  onUpdate: () => void;
  onLoad: () => void;
  onClear: () => void;
  onCopyLua: (gearSet: GearSet, augments: GearStat[]) => void;
}

export function GearSetControls({
  gearSet,
  augments,
  isAuthenticated,
  isCreating = false,
  isUpdating = false,
  isLoading = false,
  onCreateNew,
  onUpdate,
  onLoad,
  onClear,
  onCopyLua,
}: GearSetControlsProps) {
  const hasGearItems = !gearSet.gearSetItems.every((slot) => !slot.gearItem);

  return (
    <div className="absolute top-6 right-6 flex gap-2">
      {isAuthenticated && (
        <>
          {hasGearItems && (
            <button
              className={`text-gray-500 hover:text-green-600 ${isCreating ? 'opacity-50 cursor-not-allowed' : ''}`}
              title="Create new gear set"
              onClick={onCreateNew}
              disabled={isCreating || isUpdating || isLoading}
              type="button"
            >
              {isCreating ? <LoadingSpinner /> : <FaPlus className="h-5 w-5" />}
            </button>
          )}
          {gearSet.id && (
            <button
              className={`text-gray-500 hover:text-yellow-600 ${isUpdating ? 'opacity-50 cursor-not-allowed' : ''}`}
              title="Update current gear set"
              onClick={onUpdate}
              disabled={isCreating || isUpdating || isLoading}
              type="button"
            >
              {isUpdating ? <LoadingSpinner /> : <FaFloppyDisk className="h-5 w-5" />}
            </button>
          )}
          <button
            className={`text-gray-500 hover:text-blue-600 ${isLoading ? 'opacity-50 cursor-not-allowed' : ''}`}
            title="Load gear set"
            onClick={onLoad}
            disabled={isCreating || isUpdating || isLoading}
            type="button"
          >
            {isLoading ? <LoadingSpinner /> : <FaFolderOpen className="h-5 w-5" />}
          </button>
        </>
      )}
      {hasGearItems && (
        <button
          className="text-gray-500 hover:text-red-600"
          title="Clear gear set"
          onClick={onClear}
          type="button"
        >
          <RiResetLeftFill className="h-5 w-5" />
        </button>
      )}
      {hasGearItems && (
        <button
          className="text-gray-500 hover:text-purple-600"
          title="Copy lua to clipboard"
          onClick={() => onCopyLua(gearSet, augments)}
          type="button"
        >
          <FaCopy className="h-5 w-5" />
        </button>
      )}
    </div>
  );
}
