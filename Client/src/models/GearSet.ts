import type { GearItem } from "./GearItem";
import type { GearSetPosition } from "./GearSetPosition";
import type { GearSetSlot } from "./GearSetSlot";

export interface GearSet {
  id?: number;
  name: string;
  description?: string;
  slots: GearSetSlot[];
}

// Helper function to get item for a specific position
export const getItemAtPosition = (
  gearSet: GearSet,
  position: GearSetPosition
): GearItem | null => {
  return (
    gearSet.slots.find((slot) => slot.position === position)?.gearItem || null
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
    slots: gearSet.slots.map((slot) =>
      slot.position === position ? { ...slot, gearItem: item } : slot
    ),
  };
};
