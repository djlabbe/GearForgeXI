import type { GearStat } from "./GearStat";

export interface GearItem {
  id: number;
  name: string;
  category?: string;
  rank?: number;    // Augment rank (e.g., 15, 20, 25, 30)
  path?: string;    // Path letter (e.g., "A", "B", "C")
  verified: boolean; // Indicates if the item stats have been verified.
  stats: GearStat[];
  jobs: string[];   // e.g. ["WAR", "SAM", "NIN"]
  slots: string[];  // e.g. ["Main", "Sub", "Ammo"]
}