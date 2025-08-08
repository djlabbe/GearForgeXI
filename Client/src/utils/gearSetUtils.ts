import type { GearSet } from "../models/GearSet";
import type { GearStat } from "../models/GearStat";
import type { Job } from "../models/Job";
import { getItemAtPosition } from "../models/GearSet";
import { ALL_GEAR_POSITIONS } from "../models/GearSetPosition";
import type { CreateGearSetDto } from "./apiService";

/**
 * Converts a GearSet to a CreateGearSetDto for API operations
 */
export const convertGearSetToDto = (gearSet: GearSet, job: Job): CreateGearSetDto => {
  const gearSetSlots = gearSet.gearSetItems
    .filter((slot) => slot.gearItem) // Only include slots with actual items
    .map((slot) => ({
      gearItemId: slot.gearItem!.id,
      position: slot.position,
    }));

  return {
    name: gearSet.name,
    description: gearSet.description,
    jobId: job.id,
    gearSetSlots,
  };
};

/**
 * Creates a complete gear set with all positions from a loaded gear set
 */
export const createCompleteGearSet = (gearSet: GearSet): GearSet => {
  return {
    ...gearSet,
    gearSetItems: ALL_GEAR_POSITIONS.map((position) => {
      // Find existing slot for this position
      const existingSlot = gearSet.gearSetItems.find(
        (slot) => slot.position === position
      );

      if (existingSlot) {
        // Use the existing slot if it exists
        return existingSlot;
      } else {
        // Create an empty slot for this position
        return {
          id: 0,
          gearSetId: gearSet.id || 0,
          gearItemId: 0,
          position,
          gearItem: null,
        };
      }
    }),
  };
};

/**
 * Generates Lua code for a gear set and copies it to clipboard
 */
export const generateAndCopyLua = (gearSet: GearSet, augments: GearStat[]): void => {
  const luaLines: string[] = [];
  
  for (const slot of ALL_GEAR_POSITIONS) {
    const item = getItemAtPosition(gearSet, slot);
    if (item) {
      if (slot === "Back" && augments.length > 0) {
        const augStr = augments.map((a) => `${a.name}+${a.value}`).join(", ");
        luaLines.push(`    ${slot}="${item.name}" -- augments: ${augStr},`);
      } else {
        luaLines.push(`    ${slot}="${item.name}",`);
      }
    }
  }
  
  const luaString = `{\n${luaLines.join("\n")}\n}`;
  navigator.clipboard.writeText(luaString);
};
