import type { Job } from './Job';

export interface CharacterProfile {
  id: number;
  characterName: string;
  server: string;
  race: string;
  createdAt: string;
  updatedAt: string;
  characterJobs: CharacterJob[];
}

export interface CharacterJob {
  id: number;
  job: Job;
  jobLevel: number;
  masterLevel: number;
  updatedAt: string;
}

export interface CreateCharacterProfileDto {
  characterName: string;
  server: number;
  race: number;
}

export interface UpdateCharacterProfileDto {
  characterName?: string;
  server?: number;
  race?: number;
}

export interface UpdateCharacterJobDto {
  jobId: number;
  jobLevel: number;
  masterLevel: number;
}

export const SERVERS = [
  { id: 1, name: 'Bahamut' },
  { id: 2, name: 'Shiva' },
  { id: 3, name: 'Phoenix' },
  { id: 4, name: 'Carbuncle' },
  { id: 5, name: 'Fenrir' },
  { id: 6, name: 'Sylph' },
  { id: 7, name: 'Valefor' },
  { id: 8, name: 'Leviathan' },
  { id: 9, name: 'Odin' },
  { id: 10, name: 'Quetzalcoatl' },
  { id: 11, name: 'Siren' },
  { id: 12, name: 'Ragnarok' },
  { id: 13, name: 'Cerberus' },
  { id: 14, name: 'Bismarck' },
  { id: 15, name: 'Lakshmi' },
  { id: 16, name: 'Asura' },
] as const;

export const RACES = [
  { id: 1, name: 'HumeMale', displayName: 'Hume Male' },
  { id: 2, name: 'HumeFemale', displayName: 'Hume Female' },
  { id: 3, name: 'ElvaanMale', displayName: 'Elvaan Male' },
  { id: 4, name: 'ElvaanFemale', displayName: 'Elvaan Female' },
  { id: 5, name: 'TarutaruMale', displayName: 'Tarutaru Male' },
  { id: 6, name: 'TarutaruFemale', displayName: 'Tarutaru Female' },
  { id: 7, name: 'MithraFemale', displayName: 'Mithra Female' },
  { id: 8, name: 'GalkanMale', displayName: 'Galkan Male' },
] as const;

export const getRaceDisplayName = (raceName: string): string => {
  const race = RACES.find(r => r.name === raceName);
  return race ? race.displayName : raceName;
};
