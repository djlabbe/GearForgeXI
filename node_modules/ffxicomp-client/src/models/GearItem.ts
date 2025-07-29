export interface GearItem {
  id: number;
  name: string;
  slot: string;
  gearStats: GearStat[];
  gearItemJobs: GearItemJob[];
}

export interface GearStat {
  id: number;
  name: string;
  value: number;
  gearItemId: number;
}

export interface GearItemJob {
  id: number;
  jobName: string;
  gearItemId: number;
}
