// Barrel exports for all services
export { default as StatsService } from './statsService';
export { default as JobsService } from './jobsService';
export { default as JobConfigurationsService } from './jobConfigurationsService';
export { default as GearService } from './gearService';
export { default as GearSetsService } from './gearSetsService';
export { default as CharacterProfileService } from './characterProfileService';
export { default as RaceConfigurationService } from './raceConfigurationService';
export { default as CharacterSimulationService } from './characterSimulationService';

// Re-export types that are used by consumers
export type {
  GearItemSlotUpdateDto,
  GearItemCategoryUpdateDto,
  CreateGearItemDto,
  CreateGearStatDto,
} from './gearService';

export type {
  CreateGearSetDto,
  UpdateGearSetDto,
  CreateGearSetSlotDto,
  AddGearSetSlotDto,
  UpdateGearSetSlotDto,
  
} from './gearSetsService';

export type {
  CalculateStatsRequest,
  CharacterSimulationResponse,
  SimulationError,
} from '../models/CharacterSimulation';

// Additional exports for any other DTOs that might be needed
