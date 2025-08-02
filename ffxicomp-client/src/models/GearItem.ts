
export interface GearStat {
  name: string;
  value: number;
}

export interface GearItem {
  id: number;
  name: string;
  stats: GearStat[];
  jobs: string[];   // e.g. ["WAR", "SAM", "NIN"]
  slots: string[];  // e.g. ["Main", "Sub", "Ammo"]
}