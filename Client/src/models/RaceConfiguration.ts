export interface RaceConfiguration {
    id: number;
    name: string;
    abbreviation: string;
    raceBaseStats: RaceBaseStat[];
}

export interface RaceBaseStat {
    id: number;
    raceConfigurationId: number;
    statId: number;
    stat: {
        id: number;
        name: string;
        displayName?: string;
    };
    value: number;
}

export interface CreateRaceConfigurationDto {
    name: string;
    abbreviation: string;
}

export interface UpdateRaceConfigurationDto {
    id: number;
    name: string;
    abbreviation: string;
}

export interface CreateRaceBaseStatDto {
    statId: number;
    value: number;
}
