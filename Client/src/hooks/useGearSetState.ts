import { useState, useEffect } from "react";
import type { GearSet } from "../models/GearSet";
import type { GearStat } from "../models/GearStat";
import type { Job } from "../models/Job";
import { ALL_GEAR_POSITIONS } from "../models/GearSetPosition";
import ApiService from "../utils/apiService";

const createEmptySet = (name: string, job: Job): GearSet => ({
  name,
  jobId: job.id,
  job: job,
  gearSetItems: ALL_GEAR_POSITIONS.map((position) => ({
    id: 0, // temporary ID for frontend-only slots
    gearSetId: 0,
    gearItemId: 0,
    position,
    gearItem: null,
  })),
});

export function useGearSetState(job: Job, isAuthenticated: boolean) {
  // Gear set states
  const [setA, setSetA] = useState<GearSet>(() => ({
    name: "Set A",
    gearSetItems: [],
  }));
  const [setAAugments, setSetAAugments] = useState<GearStat[]>([]);

  const [setB, setSetB] = useState<GearSet>(() => ({
    name: "Set B",
    gearSetItems: [],
  }));
  const [setBAugments, setSetBAugments] = useState<GearStat[]>([]);

  // Saved gear sets from API
  const [savedGearSets, setSavedGearSets] = useState<GearSet[]>([]);

  // Dialog states
  const [showCreateNewDialog, setShowCreateNewDialog] = useState<{
    isSetA: boolean;
    show: boolean;
  }>({ isSetA: true, show: false });

  const [showLoadDialog, setShowLoadDialog] = useState<{
    isSetA: boolean;
    show: boolean;
  }>({ isSetA: true, show: false });

  const [isCreatingSet, setIsCreatingSet] = useState(false);

  // Initialize sets when job changes
  useEffect(() => {
    if (!job) return;

    const initSet = (name: string): GearSet => createEmptySet(name, job);

    setSetA(initSet("Set A"));
    setSetB(initSet("Set B"));
    setSetAAugments([]);
    setSetBAugments([]);

    // Load saved gear sets if authenticated
    if (isAuthenticated) {
      ApiService.getUserGearSets().then(setSavedGearSets).catch(console.error);
    }
  }, [job, isAuthenticated]);

  // Utility function to clear a set
  const clearSet = (isSetA: boolean) => {
    const initSet = createEmptySet(isSetA ? "Set A" : "Set B", job);

    if (isSetA) {
      setSetA(initSet);
      setSetAAugments([]);
    } else {
      setSetB(initSet);
      setSetBAugments([]);
    }
  };

  return {
    // Set states
    setA,
    setSetA,
    setAAugments,
    setSetAAugments,
    setB,
    setSetB,
    setBAugments,
    setSetBAugments,
    
    // Saved sets
    savedGearSets,
    setSavedGearSets,
    
    // Dialog states
    showCreateNewDialog,
    setShowCreateNewDialog,
    showLoadDialog,
    setShowLoadDialog,
    isCreatingSet,
    setIsCreatingSet,
    
    // Utility functions
    clearSet,
    createEmptySet: (name: string) => createEmptySet(name, job),
  };
}
