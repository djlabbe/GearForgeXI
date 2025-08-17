import { createContext, useContext, useEffect, useState } from "react";
import type { ReactNode } from "react";
import type { Job } from "../models/Job";
import type { Stat } from "../models/Stat";
import type { GearStat } from "../models/GearStat";
import ApiService from "../utils/apiService";

export interface CapeOption {
  label: string;
  stats: GearStat[];
}

interface AppDataContextType {
  categories: string[];
  statCategories: string[];
  jobs: Job[];
  slots: string[];
  stats: Stat[];
  threadOptions: CapeOption[];
  dustOptions: CapeOption[];
  sapOptions: CapeOption[];
  dyeOptions: CapeOption[];
  resinOptions: CapeOption[];
  loading: boolean;
  error: string | null;
  refreshStats: () => Promise<void>;
  refreshJobs: () => Promise<void>;
}

const AppDataContext = createContext<AppDataContextType | undefined>(undefined);

export const useAppData = () => {
  const context = useContext(AppDataContext);
  if (context === undefined) {
    throw new Error("useAppData must be used within an AppDataProvider");
  }
  return context;
};

interface AppDataProviderProps {
  children: ReactNode;
}

export const AppDataProvider = ({ children }: AppDataProviderProps) => {
  const [categories, setCategories] = useState<string[]>([]);
  const [statCategories, setStatCategories] = useState<string[]>([]);
  const [jobs, setJobs] = useState<Job[]>([]);
  const [slots, setSlots] = useState<string[]>([]);
  const [stats, setStats] = useState<Stat[]>([]);
  const [threadOptions, setThreadOptions] = useState<CapeOption[]>([]);
  const [dustOptions, setDustOptions] = useState<CapeOption[]>([]);
  const [sapOptions, setSapOptions] = useState<CapeOption[]>([]);
  const [dyeOptions, setDyeOptions] = useState<CapeOption[]>([]);
  const [resinOptions, setResinOptions] = useState<CapeOption[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  const createGearStat = (statName: string, value: number): GearStat | null => {
    const stat = stats.find((s) => s.name === statName);
    if (!stat) {
      console.error("Couldn't create stat, stat not found:", statName);
      return null;
    }
    return {
      name: stat.name,
      displayName: stat.displayName,
      category: stat.category,
      description: stat.description,
      value,
    };
  };

  const createCapeOptions = () => {
    // Thread options
    const threadOpts: CapeOption[] = [
      {
        label: "HP",
        stats: [createGearStat("HP", 60)].filter(Boolean) as GearStat[],
      },
      {
        label: "MP",
        stats: [createGearStat("MP", 60)].filter(Boolean) as GearStat[],
      },
      {
        label: "STR",
        stats: [createGearStat("STR", 20)].filter(Boolean) as GearStat[],
      },
      {
        label: "DEX",
        stats: [createGearStat("DEX", 20)].filter(Boolean) as GearStat[],
      },
      {
        label: "VIT",
        stats: [createGearStat("VIT", 20)].filter(Boolean) as GearStat[],
      },
      {
        label: "AGI",
        stats: [createGearStat("AGI", 20)].filter(Boolean) as GearStat[],
      },
      {
        label: "INT",
        stats: [createGearStat("INT", 20)].filter(Boolean) as GearStat[],
      },
      {
        label: "MND",
        stats: [createGearStat("MND", 20)].filter(Boolean) as GearStat[],
      },
      {
        label: "CHR",
        stats: [createGearStat("CHR", 20)].filter(Boolean) as GearStat[],
      },
      {
        label: "Pet: Accuracy/Attack",
        stats: [
          createGearStat("PetAccuracy", 20),
          createGearStat("PetRangedAccuracy", 20),
          createGearStat("PetAttack", 20),
          createGearStat("PetRangedAttack", 20),
        ].filter(Boolean) as GearStat[],
      },
      {
        label: "Pet: Magic Accuracy/Damage",
        stats: [
          createGearStat("PetMagicAccuracy", 20),
          createGearStat("PetMagicDamage", 20),
        ].filter(Boolean) as GearStat[],
      },
    ];

    // Dust options
    const dustOpts: CapeOption[] = [
      {
        label: "Accuracy/Attack",
        stats: [
          createGearStat("Accuracy", 20),
          createGearStat("Attack", 20),
        ].filter(Boolean) as GearStat[],
      },
      {
        label: "RangedAccuracy/RangedAttack",
        stats: [
          createGearStat("RangedAccuracy", 20),
          createGearStat("RangedAttack", 20),
        ].filter(Boolean) as GearStat[],
      },
      {
        label: "MagicAccuracy/MagicDamage",
        stats: [
          createGearStat("MagicAccuracy", 20),
          createGearStat("MagicDamage", 20),
        ].filter(Boolean) as GearStat[],
      },
      {
        label: "Evasion/MagicEvasion",
        stats: [
          createGearStat("Evasion", 20),
          createGearStat("MagicEvasion", 20),
        ].filter(Boolean) as GearStat[],
      },
    ];

    // Sap options
    const sapOpts: CapeOption[] = [
      {
        label: "Weaponskill Damage",
        stats: [createGearStat("WeaponSkillDamage", 10)].filter(
          Boolean
        ) as GearStat[],
      },
      {
        label: "Critical Hit Rate",
        stats: [createGearStat("CritRate", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Store TP",
        stats: [createGearStat("StoreTP", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Double Attack",
        stats: [createGearStat("DoubleAttack", 10)].filter(
          Boolean
        ) as GearStat[],
      },
      {
        label: "Haste",
        stats: [createGearStat("Haste", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Dual Wield",
        stats: [createGearStat("DualWield", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Enmity +",
        stats: [createGearStat("Enmity", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Enmity -",
        stats: [createGearStat("Enmity", -10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Snapshot",
        stats: [createGearStat("Snapshot", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Magic Attack",
        stats: [createGearStat("MagicAttackBonus", 10)].filter(
          Boolean
        ) as GearStat[],
      },
      {
        label: "Fast Cast",
        stats: [createGearStat("FastCast", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Cure Potency",
        stats: [createGearStat("CurePotency", 10)].filter(
          Boolean
        ) as GearStat[],
      },
      {
        label: "Waltz Potency",
        stats: [createGearStat("WaltzPotency", 10)].filter(
          Boolean
        ) as GearStat[],
      },
      {
        label: "Pet: Regen",
        stats: [createGearStat("PetRegen", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Pet: Haste",
        stats: [createGearStat("PetHaste", 10)].filter(Boolean) as GearStat[],
      },
    ];

    // Dye options
    const dyeOpts: CapeOption[] = [
      {
        label: "HP",
        stats: [createGearStat("HP", 20)].filter(Boolean) as GearStat[],
      },
      {
        label: "MP",
        stats: [createGearStat("MP", 20)].filter(Boolean) as GearStat[],
      },
      {
        label: "STR",
        stats: [createGearStat("STR", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "DEX",
        stats: [createGearStat("DEX", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "VIT",
        stats: [createGearStat("VIT", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "AGI",
        stats: [createGearStat("AGI", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "INT",
        stats: [createGearStat("INT", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "MND",
        stats: [createGearStat("MND", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "CHR",
        stats: [createGearStat("CHR", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Accuracy",
        stats: [createGearStat("Accuracy", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Attack",
        stats: [createGearStat("Attack", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Ranged Accuracy",
        stats: [createGearStat("RangedAccuracy", 10)].filter(
          Boolean
        ) as GearStat[],
      },
      {
        label: "Ranged Attack",
        stats: [createGearStat("RangedAttack", 10)].filter(
          Boolean
        ) as GearStat[],
      },
      {
        label: "Magic Accuracy",
        stats: [createGearStat("MagicAccuracy", 10)].filter(
          Boolean
        ) as GearStat[],
      },
      {
        label: "Magic Damage",
        stats: [createGearStat("MagicDamage", 10)].filter(
          Boolean
        ) as GearStat[],
      },
      {
        label: "Evasion",
        stats: [createGearStat("Evasion", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Magic Evasion",
        stats: [createGearStat("MagicEvasion", 20)].filter(
          Boolean
        ) as GearStat[],
      },
      {
        label: "Pet: Accuracy/Ranged Accuracy",
        stats: [
          createGearStat("PetAccuracy", 20),
          createGearStat("PetRangedAccuracy", 20),
        ].filter(Boolean) as GearStat[],
      },
      {
        label: "Pet: Attack/Ranged Attack",
        stats: [
          createGearStat("PetAttack", 20),
          createGearStat("PetRangedAttack", 20),
        ].filter(Boolean) as GearStat[],
      },
      {
        label: "Pet: Magic Accuracy",
        stats: [createGearStat("PetMagicAccuracy", 20)].filter(
          Boolean
        ) as GearStat[],
      },
      {
        label: "Pet: Magic Damage",
        stats: [createGearStat("PetMagicDamage", 20)].filter(
          Boolean
        ) as GearStat[],
      },
    ];

    // Resin options
    const resinOpts: CapeOption[] = [
      {
        label: "Defense",
        stats: [createGearStat("Defense", 50)].filter(Boolean) as GearStat[],
      },
      {
        label: "Evasion",
        stats: [createGearStat("Evasion", 15)].filter(Boolean) as GearStat[],
      },
      {
        label: "Magic Evasion",
        stats: [createGearStat("MagicEvasion", 15)].filter(
          Boolean
        ) as GearStat[],
      },
      {
        label: "Physical damage taken",
        stats: [createGearStat("PDT", -10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Magic damage taken",
        stats: [createGearStat("MDT", -10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Damage taken",
        stats: [createGearStat("DT", -5)].filter(Boolean) as GearStat[],
      },
      {
        label: "Regen",
        stats: [createGearStat("Regen", 5)].filter(Boolean) as GearStat[],
      },
      {
        label: "Counter",
        stats: [createGearStat("Counter", 10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Blocking rate",
        stats: [createGearStat("BlockSuccessRate", 5)].filter(
          Boolean
        ) as GearStat[],
      },
      {
        label: "Parrying rate",
        stats: [createGearStat("ParryRate", 5)].filter(Boolean) as GearStat[],
      },
      {
        label: "Status ailment resistance",
        stats: [createGearStat("StatusResist", 10)].filter(
          Boolean
        ) as GearStat[],
      },
      {
        label: "Casting interruption rate",
        stats: [createGearStat("SIRD", -10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Pet: Physical damage taken",
        stats: [createGearStat("Pet:PDT", -10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Pet: Magic damage taken",
        stats: [createGearStat("PetMDT", -10)].filter(Boolean) as GearStat[],
      },
      {
        label: "Pet: Damage taken",
        stats: [createGearStat("PetDT", -5)].filter(Boolean) as GearStat[],
      },
      {
        label: "Pet: Regen",
        stats: [createGearStat("PetRegen", 5)].filter(Boolean) as GearStat[],
      },
    ];

    setThreadOptions(threadOpts);
    setDustOptions(dustOpts);
    setSapOptions(sapOpts);
    setDyeOptions(dyeOpts);
    setResinOptions(resinOpts);
  };

  const fetchAllData = async () => {
    try {
      setLoading(true);
      setError(null);

      // Fetch all data in parallel
      const [
        categoriesData,
        statCategoriesData,
        jobsData,
        slotsData,
        statsData,
      ] = await Promise.all([
        ApiService.getAvailableGearCategories(),
        ApiService.getAvailableStatCategories(),
        ApiService.getJobs(),
        ApiService.getAvailableGearSlots(),
        ApiService.getStats(),
      ]);

      // Set all data
      setCategories(categoriesData);
      setStatCategories(statCategoriesData);
      setJobs(jobsData);
      setSlots(slotsData);
      setStats(statsData);
    } catch (err) {
      setError(
        err instanceof Error ? err.message : "Failed to fetch application data"
      );
    } finally {
      setLoading(false);
    }
  };

  const refreshStats = async () => {
    try {
      const statsData = await ApiService.getStats();
      setStats(statsData);
    } catch (err) {
      setError(
        err instanceof Error ? err.message : "Failed to refresh stats data"
      );
    }
  };

  const refreshJobs = async () => {
    try {
      const jobsData = await ApiService.getJobs();
      setJobs(jobsData);
    } catch (err) {
      setError(
        err instanceof Error ? err.message : "Failed to refresh jobs data"
      );
    }
  };

  useEffect(() => {
    fetchAllData();
  }, []);

  // Create cape options when stats are loaded
  useEffect(() => {
    if (stats.length > 0) {
      createCapeOptions();
    }
  }, [stats]);

  const value: AppDataContextType = {
    categories,
    statCategories,
    jobs,
    slots,
    stats,
    threadOptions,
    dustOptions,
    sapOptions,
    dyeOptions,
    resinOptions,
    loading,
    error,
    refreshStats,
    refreshJobs,
  };

  return (
    <AppDataContext.Provider value={value}>{children}</AppDataContext.Provider>
  );
};
