import type { Job } from "./Job";
import type { Stat } from "./Stat";

export interface JobConfiguration {
  id: number;
  jobId: number;
  job: Job;
  jobBaseStats: JobBaseStat[];
  jobTraits: JobTrait[];
  jobPointBonuses: JobPointBonus[];
  masterLevelBonuses: MasterLevelBonus[];
}

export interface JobBaseStat {
  id: number;
  jobConfigurationId: number;
  statId: number;
  stat: Stat;
  value: number;
}

export interface JobTrait {
  id: number;
  jobConfigurationId: number;
  name: string;
  level: number;
  statId: number;
  stat: Stat;
  value: number;
}

export interface JobPointBonus {
  id: number;
  jobConfigurationId: number;
  category: string;
  statId: number;
  stat: Stat;
  value: number;
}

export interface MasterLevelBonus {
  id: number;
  jobConfigurationId: number;
  level: number;
  statId: number;
  stat: Stat;
  value: number;
}
