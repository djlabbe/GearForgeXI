import type { GearItem } from "./GearItem";
import type { GearSetPosition } from "./GearSetPosition";
import type { GearSetItem } from "./GearSetItem";
import type { Job } from "./Job";

export interface GearSet {
  id?: number;
  name: string;
  description?: string;
  userId?: string;
  jobId?: number;
  job?: Job;
  gearSetItems: GearSetItem[];
}

// Helper function to get item for a specific position
export const getItemAtPosition = (
  gearSet: GearSet,
  position: GearSetPosition
): GearItem | null => {
  return (
    gearSet.gearSetItems.find((slot) => slot.position === position)?.gearItem || null
  );
};

// Helper function to set item at a specific position
export const setItemAtPosition = (
  gearSet: GearSet,
  position: GearSetPosition,
  item: GearItem | null
): GearSet => {
  return {
    ...gearSet,
    gearSetItems: gearSet.gearSetItems.map((slot) =>
      slot.position === position 
        ? { 
            ...slot, 
            gearItem: item,
            gearItemId: item?.id || 0
          } 
        : slot
    ),
  };
};
