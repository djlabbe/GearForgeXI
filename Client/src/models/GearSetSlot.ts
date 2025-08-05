import type { GearItem } from "./GearItem";
import type { GearSetPosition } from "./GearSetPosition";

export interface GearSetSlot {
  position: GearSetPosition;
  gearItem: GearItem | null;
}