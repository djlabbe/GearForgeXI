import { useState, useEffect, useCallback } from "react";
import type { GearItem } from "../models/GearItem";
import {
  setItemAtPosition,
  type GearSet,
} from "../models/GearSet";
import {
  type GearSetPosition,
} from "../models/GearSetPosition";
import { compareGearSets, type StatComparison } from "../utils/compare";
import { createAugmentedGearSet } from "../utils/gearFiltering";
import { createStatCategories } from "../constants/statCategories";
import { convertGearSetToDto, createCompleteGearSet, generateAndCopyLua } from "../utils/gearSetUtils";
import StatTable from "./StatTable";
import { GearSetCard } from "./GearSetCard";
import { CreateGearSetDialog } from "./CreateGearSetDialog";
import { LoadGearSetDialog } from "./LoadGearSetDialog";
import { useAuth } from "../contexts/AuthContext";
import { useGearSetState } from "../hooks/useGearSetState";
import ApiService, {
  type UpdateGearSetDto,
} from "../utils/apiService";
import type { Job } from "../models/Job";
import type { GearStat } from "../models/GearStat";

interface Props {
  job: Job;
  subJob?: Job;
}

export function GearSetComparer({ job, subJob }: Props) {
  const { isAuthenticated } = useAuth();
  const [gearItems, setGearItems] = useState<GearItem[]>([]);
  const [isLoadingGearData, setIsLoadingGearData] = useState(true);

  // Use custom hook for gear set state management
  const {
    setA,
    setSetA,
    setAAugments,
    setSetAAugments,
    setB,
    setSetB,
    setBAugments,
    setSetBAugments,
    savedGearSets,
    setSavedGearSets,
    showCreateNewDialog,
    setShowCreateNewDialog,
    showLoadDialog,
    setShowLoadDialog,
    isCreatingSet,
    setIsCreatingSet,
    isUpdatingSet,
    setIsUpdatingSet,
    isLoadingSet,
    setIsLoadingSet,
    successMessage,
    errorMessage,
    showSuccess,
    showError,
    clearSet,
  } = useGearSetState(job, isAuthenticated);

  const [comparison, setComparison] = useState<StatComparison[]>([]);

  useEffect(() => {
    if (!job) return;

    setIsLoadingGearData(true);

    // Get all available slots and fetch gear for each
    const slots = ["Head", "Neck", "Ear", "Body", "Hands", "Ring", "Back", "Waist", "Legs", "Feet", "Main", "Sub", "Range", "Ammo"];
    
    Promise.all(
      slots.map(slot => 
        fetch(`/api/gear?job=${job.abbreviation}&slot=${slot}`)
          .then(res => res.json())
          .catch(() => []) // Return empty array if slot has no gear
      )
    )
    .then(results => {
      // Flatten all results and remove duplicates
      const allItems = results.flat();
      const uniqueItems = allItems.filter((item, index, self) => 
        index === self.findIndex(i => i.id === item.id)
      );
      setGearItems(uniqueItems);
    })
    .finally(() => {
      setIsLoadingGearData(false);
    });
  }, [job]);

  useEffect(() => {
    // Create augmented gear sets for comparison using utility function
    const augmentedSetA = createAugmentedGearSet(setA, setAAugments);
    const augmentedSetB = createAugmentedGearSet(setB, setBAugments);

    const result = compareGearSets(augmentedSetA, augmentedSetB);
    setComparison(result);
  }, [setA, setB, setAAugments, setBAugments]);

  const handleSelect = useCallback(
    (slot: GearSetPosition, item: GearItem | undefined, isSetA: boolean) => {
      const updater = isSetA ? setSetA : setSetB;

      updater((prev) => setItemAtPosition(prev, slot, item || null));

      // Clear augments if changing back item
      if (slot === "Back") {
        if (isSetA) {
          setSetAAugments([]);
        } else {
          setSetBAugments([]);
        }
      }
    },
    []
  );

  const handleSelectA = useCallback(
    (slot: GearSetPosition, item: GearItem | undefined) => {
      handleSelect(slot, item, true);
    },
    [handleSelect]
  );

  const handleSelectB = useCallback(
    (slot: GearSetPosition, item: GearItem | undefined) => {
      handleSelect(slot, item, false);
    },
    [handleSelect]
  );

  // Save/Load handlers
  const handleCreateNewSet = async (isSetA: boolean, customSetName: string) => {
    const gearSet = isSetA ? setA : setB;

    setIsCreatingSet(true);

    try {
      // Create new gear set with custom name or default
      const setName = customSetName || gearSet.name;

      const gearSetDto = convertGearSetToDto(gearSet, job);
      gearSetDto.name = setName;

      const newGearSet = await ApiService.createGearSet(gearSetDto);

      // Update the local state with the new ID and name, keeping existing slots
      if (isSetA) {
        setSetA((prev) => ({ ...prev, id: newGearSet.id, name: setName }));
      } else {
        setSetB((prev) => ({ ...prev, id: newGearSet.id, name: setName }));
      }

      // Refresh saved gear sets list
      if (isAuthenticated) {
        const updatedSets = await ApiService.getUserGearSets();
        setSavedGearSets(updatedSets);
      }

      showSuccess(`"${setName}" created successfully!`);
      setShowCreateNewDialog({ isSetA: false, show: false });
    } catch (error) {
      console.error("Failed to create new gear set:", error);
      showError("Failed to create gear set. Please try again.");
    } finally {
      setIsCreatingSet(false);
    }
  };

  const handleUpdateSet = async (isSetA: boolean) => {
    const gearSet = isSetA ? setA : setB;

    if (!gearSet.id) {
      console.error("Cannot update set without ID");
      showError("Cannot update gear set: No ID found");
      return;
    }

    setIsUpdatingSet(true);

    try {
      // Update existing gear set using full replacement
      const gearSetDto: UpdateGearSetDto = convertGearSetToDto(gearSet, job);

      await ApiService.updateGearSet(gearSet.id, gearSetDto);

      // Refresh saved gear sets list
      if (isAuthenticated) {
        const updatedSets = await ApiService.getUserGearSets();
        setSavedGearSets(updatedSets);
      }

      showSuccess(`"${gearSet.name}" updated successfully!`);
    } catch (error) {
      console.error("Failed to update gear set:", error);
      showError("Failed to update gear set. Please try again.");
    } finally {
      setIsUpdatingSet(false);
    }
  };

  const handleClearSet = (isSetA: boolean) => {
    clearSet(isSetA);
  };

  const handleLoadGearSet = (isSetA: boolean, gearSet: GearSet) => {
    setIsLoadingSet(true);
    
    try {
      const completeGearSet = createCompleteGearSet(gearSet);

      if (isSetA) {
        setSetA(completeGearSet);
      } else {
        setSetB(completeGearSet);
      }
      
      setShowLoadDialog({ isSetA: false, show: false });
    } catch (error) {
      console.error("Failed to load gear set:", error);
      showError("Failed to load gear set. Please try again.");
    } finally {
      setIsLoadingSet(false);
    }
  };

  const statCategories = createStatCategories();

  const getStatsByCategory = (category: string) => {
    return comparison
      .filter((c) => c.stat.category === category)
      .slice()
      .sort((a, b) => a.stat.name.localeCompare(b.stat.name));
  };

  const categorizedStats = statCategories.map((category) => ({
    ...category,
    stats: getStatsByCategory(category.key),
  }));

  const handleCopyLua = (gearSet: GearSet, augments: GearStat[]) => {
    generateAndCopyLua(gearSet, augments);
  };

  return (
    <div>
      {/* Success/Error Messages */}
      {successMessage && (
        <div className="mb-4 p-4 bg-green-100 border-l-4 border-green-500 text-green-700 rounded">
          <div className="flex items-center">
            <svg className="w-5 h-5 mr-2" fill="currentColor" viewBox="0 0 20 20">
              <path fillRule="evenodd" d="M10 18a8 8 0 100-16 8 8 0 000 16zm3.707-9.293a1 1 0 00-1.414-1.414L9 10.586 7.707 9.293a1 1 0 00-1.414 1.414l2 2a1 1 0 001.414 0l4-4z" clipRule="evenodd" />
            </svg>
            {successMessage}
          </div>
        </div>
      )}

      {errorMessage && (
        <div className="mb-4 p-4 bg-red-100 border-l-4 border-red-500 text-red-700 rounded">
          <div className="flex items-center">
            <svg className="w-5 h-5 mr-2" fill="currentColor" viewBox="0 0 20 20">
              <path fillRule="evenodd" d="M10 18a8 8 0 100-16 8 8 0 000 16zM8.707 7.293a1 1 0 00-1.414 1.414L8.586 10l-1.293 1.293a1 1 0 101.414 1.414L10 11.414l1.293 1.293a1 1 0 001.414-1.414L11.414 10l1.293-1.293a1 1 0 00-1.414-1.414L10 8.586 8.707 7.293z" clipRule="evenodd" />
            </svg>
            {errorMessage}
          </div>
        </div>
      )}

      <div className="grid grid-cols-1 md:grid-cols-2 mb-4 gap-4">
        {isLoadingGearData ? (
          <div className="col-span-1 md:col-span-2 flex items-center justify-center py-12">
            <div className="text-center">
              <div className="inline-block animate-spin rounded-full h-8 w-8 border-b-2 border-blue-600 mb-4"></div>
              <p className="text-gray-600 dark:text-gray-400">Loading gear data...</p>
            </div>
          </div>
        ) : (
          <>
            <GearSetCard
              gearSet={setA}
              augments={setAAugments}
              gearItems={gearItems}
              job={job}
              subJob={subJob}
              isAuthenticated={isAuthenticated}
              setName="Set A"
              isCreating={isCreatingSet}
              isUpdating={isUpdatingSet}
              isLoading={isLoadingSet}
              onSelect={handleSelectA}
              onAugmentChange={setSetAAugments}
              onCreateNew={() => setShowCreateNewDialog({ isSetA: true, show: true })}
              onUpdate={() => handleUpdateSet(true)}
              onLoad={() => setShowLoadDialog({ isSetA: true, show: true })}
              onClear={() => handleClearSet(true)}
              onCopyLua={handleCopyLua}
            />
            
            <GearSetCard
              gearSet={setB}
              augments={setBAugments}
              gearItems={gearItems}
              job={job}
              subJob={subJob}
              isAuthenticated={isAuthenticated}
              setName="Set B"
              isCreating={isCreatingSet}
              isUpdating={isUpdatingSet}
              isLoading={isLoadingSet}
              onSelect={handleSelectB}
              onAugmentChange={setSetBAugments}
              onCreateNew={() => setShowCreateNewDialog({ isSetA: false, show: true })}
              onUpdate={() => handleUpdateSet(false)}
              onLoad={() => setShowLoadDialog({ isSetA: false, show: true })}
              onClear={() => handleClearSet(false)}
              onCopyLua={handleCopyLua}
            />
          </>
        )}
      </div>

      {!isLoadingGearData && comparison.length > 0 && (
        <div className="grid grid-cols-1 md:grid-cols-3 gap-4 mb-4">
          {categorizedStats.map((category) => (
            <StatTable
              key={category.key}
              title={category.title}
              statComparison={category.stats}
              icon={category.icon}
            />
          ))}
        </div>
      )}

      {/* Create New Set Dialog */}
      <CreateGearSetDialog
        isOpen={showCreateNewDialog.show}
        job={job}
        isCreatingSet={isCreatingSet}
        onClose={() => setShowCreateNewDialog({ isSetA: false, show: false })}
        onCreateSet={(setName) => handleCreateNewSet(showCreateNewDialog.isSetA, setName)}
      />

      {/* Load Dialog */}
      <LoadGearSetDialog
        isOpen={showLoadDialog.show}
        job={job}
        savedGearSets={savedGearSets}
        targetSet={showLoadDialog.isSetA ? "A" : "B"}
        isLoading={isLoadingSet}
        onClose={() => setShowLoadDialog({ isSetA: false, show: false })}
        onLoadGearSet={(gearSet) => handleLoadGearSet(showLoadDialog.isSetA, gearSet)}
      />
    </div>
  );
}
