export interface GearItem {
  id: number;
  name: string;
  slot: string;
  gearStats: GearStat[];
  gearItemJobs: GearItemJob[];
}

export interface GearStat {
  name: string;
  value: number;
}

export interface GearItemJob {
  jobName: string;
}
