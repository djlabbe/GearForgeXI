import type { GearItem } from "./GearItem";
import type { GearSetPosition } from "./GearSetPosition";

export interface GearSetItem {
  id?: number;
  position: GearSetPosition;
  gearSetId?: number;
  gearItemId: number;
  gearItem?: GearItem | null;
}