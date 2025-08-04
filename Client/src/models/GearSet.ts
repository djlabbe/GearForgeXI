import type { GearItem } from "./GearItem";

export type GearSlot =
  | "main"
  | "sub"
  | "range"
  | "ammo"
  | "head"
  | "neck"
  | "ear1"
  | "ear2"
  | "body"
  | "hands"
  | "ring1"
  | "ring2"
  | "back"
  | "waist"
  | "legs"
  | "feet";

export type GearSet = {
  [K in GearSlot]?: GearItem;
};
