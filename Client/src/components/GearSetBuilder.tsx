import { useState, useEffect, useCallback } from "react";
import type { GearItem } from "../models/GearItem";
import {
  setItemAtPosition,
  type GearSet,
} from "../models/GearSet";
import {
  type GearSetPosition,
} from "../models/GearSetPosition";
import { getTotalStats } from "../utils/compare";
import { createAugmentedGearSet } from "../utils/gearFiltering";
import { createStatCategories } from "../constants/statCategories";
import { convertGearSetToDto, createCompleteGearSet, generateAndCopyLua } from "../utils/gearSetUtils";
import { GearSetCard } from "./GearSetCard";
import { CreateGearSetDialog } from "./CreateGearSetDialog";
import { LoadGearSetDialog } from "./LoadGearSetDialog";
import { useAuth } from "../contexts/AuthContext";
import { useGearSetState } from "../hooks/useGearSetState";
import { GearSetsService, type UpdateGearSetDto } from "../services";
import type { Job } from "../models/Job";
import type { GearStat } from "../models/GearStat";
import { SingleStatTable } from "./SingleStatTable";

interface Props {
  job: Job;
  subJob?: Job;
}

export function GearSetBuilder({ job, subJob }: Props) {
  const { isAuthenticated } = useAuth();
  const [gearItems, setGearItems] = useState<GearItem[]>([]);
  const [isLoadingGearData, setIsLoadingGearData] = useState(true);

  // Use custom hook for gear set state management (only need one set)
  const {
    setA: gearSet,
    setSetA: setGearSet,
    setAAugments: augments,
    setSetAAugments: setAugments,
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

  const [stats, setStats] = useState<{
    numericStats: Map<string, { stat: GearStat; value: number }>;
    nonNumericStats: Map<string, GearStat[]>;
  }>({ numericStats: new Map(), nonNumericStats: new Map() });

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
    // Calculate stats for the single gear set using utility function
    const augmentedSet = createAugmentedGearSet(gearSet, augments);
    const result = getTotalStats(augmentedSet);
    setStats(result);
  }, [gearSet, augments]);

  const handleSelect = useCallback(
    (slot: GearSetPosition, item: GearItem | undefined) => {
      setGearSet((prev) => setItemAtPosition(prev, slot, item || null));

      // Clear augments if changing back item
      if (slot === "Back") {
        setAugments([]);
      }
    },
    []
  );

  // Save/Load handlers
  const handleCreateNewSet = async (customSetName: string) => {
    setIsCreatingSet(true);

    try {
      // Create new gear set with custom name or default
      const setName = customSetName || gearSet.name;

      const gearSetDto = convertGearSetToDto(gearSet, job);
      gearSetDto.name = setName;

      const newGearSet = await GearSetsService.createGearSet(gearSetDto);

      // Update the local state with the new ID and name, keeping existing slots
      setGearSet((prev) => ({ ...prev, id: newGearSet.id, name: setName }));

      // Refresh saved gear sets list
      if (isAuthenticated) {
        const updatedSets = await GearSetsService.getUserGearSets();
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

  const handleUpdateSet = async () => {
    if (!gearSet.id) {
      console.error("Cannot update set without ID");
      showError("Cannot update gear set: No ID found");
      return;
    }

    setIsUpdatingSet(true);

    try {
      // Update existing gear set using full replacement
      const gearSetDto: UpdateGearSetDto = convertGearSetToDto(gearSet, job);

      await GearSetsService.updateGearSet(gearSet.id, gearSetDto);

      // Refresh saved gear sets list
      if (isAuthenticated) {
        const updatedSets = await GearSetsService.getUserGearSets();
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

  const handleClearSet = () => {
    clearSet(true); // Use true since we're treating this as "Set A" internally
  };

  const handleLoadGearSet = (loadedGearSet: GearSet) => {
    setIsLoadingSet(true);
    
    try {
      const completeGearSet = createCompleteGearSet(loadedGearSet);
      setGearSet(completeGearSet);
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
    const categoryStats: Array<{ stat: GearStat; value: number | boolean }> = [];
    
    // Add numeric stats for this category
    stats.numericStats.forEach((statData) => {
      if (statData.stat.category === category) {
        categoryStats.push({ stat: statData.stat, value: statData.value });
      }
    });
    
    // Add non-numeric stats for this category
    stats.nonNumericStats.forEach((statArray) => {
      if (statArray.length > 0 && statArray[0].category === category) {
        categoryStats.push({ stat: statArray[0], value: true });
      }
    });
    
    return categoryStats.sort((a, b) => a.stat.name.localeCompare(b.stat.name));
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

      <div className="mb-4">
        {isLoadingGearData ? (
          <div className="flex items-center justify-center py-12">
            <div className="text-center">
              <div className="inline-block animate-spin rounded-full h-8 w-8 border-b-2 border-blue-600 mb-4"></div>
              <p className="text-gray-600 dark:text-gray-400">Loading gear data...</p>
            </div>
          </div>
        ) : (
          <GearSetCard
            gearSet={gearSet}
            augments={augments}
            gearItems={gearItems}
            job={job}
            subJob={subJob}
            isAuthenticated={isAuthenticated}
            setName="Gear Set"
            isCreating={isCreatingSet}
            isUpdating={isUpdatingSet}
            isLoading={isLoadingSet}
            onSelect={handleSelect}
            onAugmentChange={setAugments}
            onCreateNew={() => setShowCreateNewDialog({ isSetA: true, show: true })}
            onUpdate={handleUpdateSet}
            onLoad={() => setShowLoadDialog({ isSetA: true, show: true })}
            onClear={handleClearSet}
            onCopyLua={handleCopyLua}
          />
        )}
      </div>

      {!isLoadingGearData && (
        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4 mb-4">
          {categorizedStats.map((category) => (
            category.stats.length > 0 && (
              <SingleStatTable
                key={category.key}
                title={category.title}
                stats={category.stats}
                icon={category.icon}
              />
            )
          ))}
        </div>
      )}

      {/* Create New Set Dialog */}
      <CreateGearSetDialog
        isOpen={showCreateNewDialog.show}
        job={job}
        isCreatingSet={isCreatingSet}
        onClose={() => setShowCreateNewDialog({ isSetA: false, show: false })}
        onCreateSet={handleCreateNewSet}
      />

      {/* Load Dialog */}
      <LoadGearSetDialog
        isOpen={showLoadDialog.show}
        job={job}
        savedGearSets={savedGearSets}
        targetSet="A"
        isLoading={isLoadingSet}
        onClose={() => setShowLoadDialog({ isSetA: false, show: false })}
        onLoadGearSet={handleLoadGearSet}
      />
    </div>
  );
}
