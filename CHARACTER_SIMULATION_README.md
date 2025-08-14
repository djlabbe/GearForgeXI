# FFXI Character Simulation System (Simplified)

## Overview

This system provides a complete character simulation for Final Fantasy XI, combining character profiles, job data, and gear sets to calculate comprehensive character statistics. **The system assumes all main jobs are level 99** for simplicity, while subjobs can vary in level and can have master levels.

## Architecture

### Static Job Configuration
- **JobConfigurations.cs**: Contains static data for all jobs including traits, job point bonuses, and master level bonuses
- **JobStaticData.cs**: Model for job configuration data
- **JobTrait.cs**: Model for individual job traits

### Character Simulation
- **CharacterSimulationService.cs**: Core service that combines all stat sources
- **CharacterStats.cs**: Model representing complete character statistics
- **CharacterSimulationController.cs**: API endpoints for character simulation

### Key Features

1. **Race Base Stats**: Different racial starting statistics
2. **Fixed Job Stats**: Level 99 stats for main jobs, scaled stats for subjobs
3. **Job Traits**: All traits are active (since main jobs are level 99)
4. **Job Point Bonuses**: All-or-nothing bonuses when a job is "mastered" (level 99 + any master levels)
5. **Master Level Bonuses**: Progressive bonuses based on master level (0-50)
6. **Subjob Support**: Reduced benefits from subjob, can have master levels, capped at level 49
7. **Gear Integration**: Combines with existing gear set system

## Simplified Assumptions

- **Main jobs are always level 99** - no more level-based calculations
- **Subjobs can vary in level** but are capped at 49
- **Both main and subjobs can have master levels** and get scaled benefits
- **Job Point bonuses apply to both main and subjob** if mastered (with scaling)
- **All job traits are active** for main jobs since they're level 99

## API Endpoints

### POST /api/CharacterSimulation/calculate
Calculate complete character stats for a specific character profile and gear set.

**Request Body:**
```json
{
  "characterProfileId": 1,
  "mainJobId": 1,
  "subJobId": 6,
  "gearSetId": 1
}
```

**Response:**
```json
{
  "characterName": "MyCharacter",
  "race": "HumeMale",
  "mainJob": "WAR",
  "mainJobLevel": 99,        // Always 99 for main jobs
  "mainJobMasterLevel": 25,
  "subJob": "THF",
  "subJobLevel": 45,         // Can vary for subjobs (max 49)
  "gearSetName": "My Gear Set",
  "stats": {
    "str": 150,
    "dex": 120,
    // ... all character stats
    "activeTraits": ["Attack Bonus", "Double Attack"], // All traits active for level 99 main job
    "statBreakdown": {
      "STR": [
        {"value": 7, "source": "Race"},
        {"value": 50, "source": "Job Level (99)"},      // Fixed bonus for level 99
        {"value": 16, "source": "Job Points"},
        {"value": 8, "source": "Master Level (25)"}
      ]
    }
  },
  "calculatedAt": "2025-08-13T..."
}
```

### GET /api/CharacterSimulation/example
Returns an example calculation with mock data to demonstrate the system.

### GET /api/CharacterSimulation/job-configurations
Lists all configured jobs and their configuration status.

### GET /api/CharacterSimulation/job-configurations/{jobId}
Returns detailed configuration for a specific job.

## Job Configuration Format

Jobs are configured with three main components:

### 1. Traits
Level-based passive abilities:
```csharp
new JobTrait { 
    Name = "Double Attack", 
    Level = 25, 
    StatModifiers = { ["DA"] = 10 } 
}
```

### 2. Job Point Bonuses
All-or-nothing bonuses when mastered:
```csharp
JobPointBonuses = new()
{
    ["Attack"] = 70,
    ["Accuracy"] = 70,
    ["STR"] = 16,
    ["VIT"] = 16
}
```

### 3. Master Level Bonuses
Progressive bonuses (0-50 master levels):
```csharp
MasterLevelBonuses = new()
{
    ["Attack"] = 50,    // Total bonus at ML50
    ["Accuracy"] = 50   // Scales with current ML
}
```

## Currently Configured Jobs

- WAR (Warrior) - Complete
- MNK (Monk) - Complete  
- WHM (White Mage) - Complete
- BLM (Black Mage) - Complete
- RDM (Red Mage) - Complete
- THF (Thief) - Complete
- PLD (Paladin) - Complete
- DRK (Dark Knight) - Complete
- NIN (Ninja) - Complete
- SAM (Samurai) - Complete

## Integration with Existing System

This system integrates seamlessly with your existing models:
- Uses existing `Job`, `CharacterProfile`, `CharacterJob` entities
- Works with existing `GearSet` and gear item system
- Extends functionality without breaking existing API contracts

## Usage Examples

1. **Gear Set Comparison**: Compare total character performance with different gear sets
2. **Job Planning**: See stat changes when switching jobs or reaching master levels
3. **Build Optimization**: Understand how job traits and gear interact
4. **Character Development**: Track progression through levels and master levels

## Future Enhancements

- Add remaining 12 jobs (BST, BRD, RNG, DRG, SMN, BLU, COR, PUP, DNC, SCH, GEO, RUN)
- More accurate job level stat growth formulas
- Food/buff simulation
- Merit point system
- Advanced trait interactions (e.g., dual wield delay calculations)
- Equipment skill modifiers
- Weapon skill damage calculations
