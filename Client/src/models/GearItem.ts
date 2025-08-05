import type { GearStat } from "./GearStat";

export interface GearItem {
  id: number;
  name: string;
  category?: string;
  stats: GearStat[];
  jobs: string[];   // e.g. ["WAR", "SAM", "NIN"]
  slots: string[];  // e.g. ["Main", "Sub", "Ammo"]
}