import {
  FaCopy,
  FaFloppyDisk,
  FaFolderOpen,
  FaPlus,
} from "react-icons/fa6";
import type { GearSet } from "../models/GearSet";
import type { GearStat } from "../models/GearStat";
import { RiResetLeftFill } from "react-icons/ri";
import { BsLightningChargeFill } from "react-icons/bs";

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
            <div className="relative group">
              <button
                className={`text-gray-500 hover:text-green-600 ${isCreating ? 'opacity-50 cursor-not-allowed' : ''}`}
                onClick={onCreateNew}
                disabled={isCreating || isUpdating || isLoading}
                type="button"
              >
                {isCreating ? <LoadingSpinner /> : <FaPlus className="h-5 w-5" />}
              </button>
              <div className="absolute bottom-full left-1/2 transform -translate-x-1/2 mb-2 px-3 py-2 text-sm text-white bg-gray-900 rounded-lg opacity-0 group-hover:opacity-100 transition-opacity duration-200 pointer-events-none whitespace-nowrap z-10">
                Create new gear set
                <div className="absolute top-full left-1/2 transform -translate-x-1/2 w-0 h-0 border-l-4 border-r-4 border-t-4 border-transparent border-t-gray-900"></div>
              </div>
            </div>
          )}
          {gearSet.id && (
            <div className="relative group">
              <button
                className={`text-gray-500 hover:text-yellow-600 ${isUpdating ? 'opacity-50 cursor-not-allowed' : ''}`}
                onClick={onUpdate}
                disabled={isCreating || isUpdating || isLoading}
                type="button"
              >
                {isUpdating ? <LoadingSpinner /> : <FaFloppyDisk className="h-5 w-5" />}
              </button>
              <div className="absolute bottom-full left-1/2 transform -translate-x-1/2 mb-2 px-3 py-2 text-sm text-white bg-gray-900 rounded-lg opacity-0 group-hover:opacity-100 transition-opacity duration-200 pointer-events-none whitespace-nowrap z-10">
                Update current gear set
                <div className="absolute top-full left-1/2 transform -translate-x-1/2 w-0 h-0 border-l-4 border-r-4 border-t-4 border-transparent border-t-gray-900"></div>
              </div>
            </div>
          )}
          <div className="relative group">
            <button
              className={`text-gray-500 hover:text-blue-600 ${isLoading ? 'opacity-50 cursor-not-allowed' : ''}`}
              onClick={onLoad}
              disabled={isCreating || isUpdating || isLoading}
              type="button"
            >
              {isLoading ? <LoadingSpinner /> : <FaFolderOpen className="h-5 w-5" />}
            </button>
            <div className="absolute bottom-full left-1/2 transform -translate-x-1/2 mb-2 px-3 py-2 text-sm text-white bg-gray-900 rounded-lg opacity-0 group-hover:opacity-100 transition-opacity duration-200 pointer-events-none whitespace-nowrap z-10">
              Load gear set
              <div className="absolute top-full left-1/2 transform -translate-x-1/2 w-0 h-0 border-l-4 border-r-4 border-t-4 border-transparent border-t-gray-900"></div>
            </div>
          </div>
        </>
      )}
      {hasGearItems && (
        <div className="relative group">
          <button
            className="text-gray-500 hover:text-red-600"
            onClick={onClear}
            type="button"
          >
            <RiResetLeftFill className="h-5 w-5" />
          </button>
          <div className="absolute bottom-full left-1/2 transform -translate-x-1/2 mb-2 px-3 py-2 text-sm text-white bg-gray-900 rounded-lg opacity-0 group-hover:opacity-100 transition-opacity duration-200 pointer-events-none whitespace-nowrap z-10">
            Clear gear set
            <div className="absolute top-full left-1/2 transform -translate-x-1/2 w-0 h-0 border-l-4 border-r-4 border-t-4 border-transparent border-t-gray-900"></div>
          </div>
        </div>
      )}
      {hasGearItems && (
        <div className="relative group">
          <button
            className="text-gray-500 hover:text-purple-600"
            onClick={() => onCopyLua(gearSet, augments)}
            type="button"
          >
            <FaCopy className="h-5 w-5" />
          </button>
          <div className="absolute bottom-full left-1/2 transform -translate-x-1/2 mb-2 px-3 py-2 text-sm text-white bg-gray-900 rounded-lg opacity-0 group-hover:opacity-100 transition-opacity duration-200 pointer-events-none whitespace-nowrap z-10">
            Copy lua to clipboard
            <div className="absolute top-full left-1/2 transform -translate-x-1/2 w-0 h-0 border-l-4 border-r-4 border-t-4 border-transparent border-t-gray-900"></div>
          </div>
        </div>
      )}
      {hasGearItems && (
        <div className="relative group">
          <button
            className="flex items-center gap-1 px-2 py-1 text-xs font-medium text-gray-500 hover:text-white bg-transparent hover:bg-gradient-to-r hover:from-purple-600 hover:to-indigo-600 rounded border border-gray-300 hover:border-purple-500 transition-all duration-200 hover:shadow-md dark:border-gray-600 dark:hover:border-purple-400"
            onClick={() => {
              // TODO: Implement simulation functionality
            }}
            type="button"
          >
            <BsLightningChargeFill className="h-3 w-3" />
            <span>Run Sim</span>
          </button>
          <div className="absolute bottom-full left-1/2 transform -translate-x-1/2 mb-2 px-3 py-2 text-sm text-white bg-gray-900 rounded-lg opacity-0 group-hover:opacity-100 transition-opacity duration-200 pointer-events-none whitespace-nowrap z-10">
            Simulate gear set
            <div className="absolute top-full left-1/2 transform -translate-x-1/2 w-0 h-0 border-l-4 border-r-4 border-t-4 border-transparent border-t-gray-900"></div>
          </div>
        </div>
      )}
    </div>
  );
}
