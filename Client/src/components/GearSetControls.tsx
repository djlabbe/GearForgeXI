import {
  FaCopy,
  FaFloppyDisk,
  FaFolderOpen,
  FaPlus,
  FaTrash,
} from "react-icons/fa6";
import type { GearSet } from "../models/GearSet";
import type { GearStat } from "../models/GearStat";

interface GearSetControlsProps {
  gearSet: GearSet;
  augments: GearStat[];
  isAuthenticated: boolean;
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
              className="text-gray-500 hover:text-green-600"
              title="Create new gear set"
              onClick={onCreateNew}
              type="button"
            >
              <FaPlus className="h-5 w-5" />
            </button>
          )}
          {gearSet.id && (
            <button
              className="text-gray-500 hover:text-yellow-600"
              title="Update current gear set"
              onClick={onUpdate}
              type="button"
            >
              <FaFloppyDisk className="h-5 w-5" />
            </button>
          )}
          <button
            className="text-gray-500 hover:text-blue-600"
            title="Load gear set"
            onClick={onLoad}
            type="button"
          >
            <FaFolderOpen className="h-5 w-5" />
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
          <FaTrash className="h-5 w-5" />
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
