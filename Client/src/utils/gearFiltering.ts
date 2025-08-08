import type { GearItem } from "../models/GearItem";
import type { GearSet } from "../models/GearSet";
import type { GearSetPosition } from "../models/GearSetPosition";
import type { Job } from "../models/Job";
import type { GearStat } from "../models/GearStat";
import { getItemAtPosition } from "../models/GearSet";

/**
 * Normalizes slot names for dual-slot cases (ears and rings)
 */
const normalizeSlotName = (slot: string): string => {
  const lowerSlot = slot.toLowerCase();
  
  if (lowerSlot === "ear1" || lowerSlot === "ear2") return "earrings";
  if (lowerSlot === "ring1" || lowerSlot === "ring2") return "rings";
  
  return lowerSlot;
};

/**
 * Filters items based on sub-weapon slot compatibility
 */
const filterSubSlotItems = (
  items: GearItem[],
  mainItem: GearItem | null,
  job: Job,
  subJob?: Job
): GearItem[] => {
  if (!mainItem) return items;

  if (mainItem.category === "2H") {
    return items.filter((item) => item.category === "Grip");
  }

  if (mainItem.category === "1H") {
    const canDualWield = 
      job.canDualWield ||
      subJob?.abbreviation === "NIN" ||
      subJob?.abbreviation === "DNC";

    if (canDualWield) {
      return items.filter(
        (item) => item.category === "1H" || item.category === "Shield"
      );
    } else {
      return items.filter((item) => item.category === "Shield");
    }
  }

  return items;
};

/**
 * Filters items based on ammo slot compatibility with ranged weapon
 */
const filterAmmoSlotItems = (
  items: GearItem[],
  rangeItem: GearItem | null
): GearItem[] => {
  if (!rangeItem || !rangeItem.category) return items;

  const ammoTypeMap: Record<string, string> = {
    "Gun": "Bullet",
    "Crossbow": "Bolt", 
    "Bow": "Arrow"
  };

  const requiredAmmoType = ammoTypeMap[rangeItem.category];
  
  return requiredAmmoType
    ? items.filter((item) => item.category === requiredAmmoType)
    : items;
};

/**
 * Gets all gear items that are compatible with a specific equipment slot
 * Applies job-specific filtering and weapon compatibility rules
 */
export const getItemsBySlot = (
  gearItems: GearItem[],
  currentSet: GearSet,
  slot: GearSetPosition,
  job: Job,
  subJob?: Job
): GearItem[] => {
  const normalizedSlot = normalizeSlotName(slot);

  // Filter items that can be equipped in this slot
  let items = gearItems.filter((item) =>
    item.slots.map((s) => s.toLowerCase()).includes(normalizedSlot)
  );

  // Apply slot-specific filtering rules
  if (normalizedSlot === "sub") {
    const mainItem = getItemAtPosition(currentSet, "Main");
    items = filterSubSlotItems(items, mainItem, job, subJob);
  }

  if (normalizedSlot === "ammo") {
    const rangeItem = getItemAtPosition(currentSet, "Range");
    items = filterAmmoSlotItems(items, rangeItem);
  }

  return items;
};

/**
 * Creates an augmented gear set by adding cape augments to the back item
 */
export const createAugmentedGearSet = (
  gearSet: GearSet,
  augments: GearStat[]
): GearSet => {
  if (augments.length === 0) return gearSet;

  const backItem = getItemAtPosition(gearSet, "Back");
  if (!backItem) return gearSet;

  const augmentedBackItem = {
    ...backItem,
    stats: [...backItem.stats, ...augments],
  };

  return {
    ...gearSet,
    gearSetItems: gearSet.gearSetItems.map((slot) =>
      slot.position === "Back" 
        ? { ...slot, gearItem: augmentedBackItem } 
        : slot
    ),
  };
};
