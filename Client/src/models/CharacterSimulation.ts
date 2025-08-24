export interface CalculateStatsRequest {
  raceId: number;
  mainJobId: number;
  masterLevel: number;
  subJobId?: number | null;
  subJobLevel?: number | null;
  gearSetId?: number | null;
}

export interface CharacterStatistic {
  statName: string;
  value: number;
  baseValue?: number;
  raceModifier?: number;
  jobModifier?: number;
  gearModifier?: number;
  masterLevelModifier?: number;
}

export interface CharacterSimulationResponse {
  characterName: string;
  race: string;
  mainJob: string;
  mainJobLevel: number;
  subJob: string | null;
  subJobLevel: number | null;
  masterLevel: number;
  gearSetName: string | null;
  calculatedAt: string;
  gear: CharacterSimulationGear;
  derivedStats: CharacterSimulationDerivedStats;
  stats: { [statName: string]: number | null };
  statBreakdown: { [statName: string]: { value: number; source: string }[] };
}

export interface CharacterSimulationGear {
  main: string | null;
  sub: string | null;
  range: string | null;
  ammo: string | null;
  head: string | null;
  neck: string | null;
  ear1: string | null;
  ear2: string | null;
  body: string | null;
  hands: string | null;
  ring1: string | null;
  ring2: string | null;
  back: string | null;
  waist: string | null;
  legs: string | null;
  feet: string | null;
}

export interface CharacterSimulationDerivedStats {
  maxHp: number;
  maxMp: number;
  primaryAccuracy: number;
  primaryAttack: number;
  auxiliaryAccuracy: number;
  auxiliaryAttack: number;
  rangedAccuracy: number;
  rangedAttack: number;
  totalEvasion: number;
  totalDefense: number;
}

export interface SimulationError {
  message: string;
  error?: string;
  stackTrace?: string;
  innerException?: string;
}
