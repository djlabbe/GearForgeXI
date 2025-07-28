import type { GearItem } from "./GearItem";

export interface GearSet {
  head?: GearItem;
  body?: GearItem;
  hands?: GearItem;
  legs?: GearItem;
  feet?: GearItem;
  ranged?: GearItem;
  ammo?: GearItem;
  neck?: GearItem;
  ear1?: GearItem;
  ear2?: GearItem;
  ring1?: GearItem;
  ring2?: GearItem;
  back?: GearItem;
  waist?: GearItem;
  main?: GearItem;
  sub?: GearItem;
}
