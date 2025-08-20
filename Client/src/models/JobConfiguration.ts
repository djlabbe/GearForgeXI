import type { Job } from "./Job";
import type { Stat } from "./Stat";

export interface JobConfiguration {
  id: number;
  jobId: number;
  job: Job;
  jobBaseStats: JobBaseStat[];
  jobBaseSkills: JobBaseSkill[];
  jobTraits: JobTrait[];
  jobPointBonuses: JobPointBonus[];
  jobGifts: JobGift[];
  masterLevelBonuses: MasterLevelBonus[];
}

export interface JobBaseStat {
  id: number;
  jobConfigurationId: number;
  statId: number;
  stat: Stat;
  value: number;
}

export interface JobBaseSkill {
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
  statId: number;
  stat: Stat;
  value: number;
}

export interface JobGift {
  id: number;
  jobConfigurationId: number;
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
