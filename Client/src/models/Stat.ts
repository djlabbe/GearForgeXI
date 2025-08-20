export interface Stat {
  id: number;
  name: string;
  displayName?: string;
  alternateName1?: string;
  alternateName2?: string;
  category?: string;
  description?: string;
  gearItemCount?: number;
  baseStatCount?: number;
  jobTraitCount?: number;
  jobPointBonusCount?: number;
  jobGiftCount?: number;
  masterLevelBonusCount?: number;
  isBaseStat?: boolean;
  canDelete?: boolean;
}
