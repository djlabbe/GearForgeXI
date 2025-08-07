import type { GearStat } from "./GearStat";

export interface GearItem {
  id: number;
  name: string;
  category?: string;
  verified: boolean; // Indicates if the item stats have been verified.
  stats: GearStat[];
  jobs: string[];   // e.g. ["WAR", "SAM", "NIN"]
  slots: string[];  // e.g. ["Main", "Sub", "Ammo"]
}