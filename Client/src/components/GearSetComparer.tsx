import { useState, useEffect, useCallback } from "react";
import type { GearItem } from "../models/GearItem";
import {
  getItemAtPosition,
  setItemAtPosition,
  type GearSet,
} from "../models/GearSet";
import {
  ALL_GEAR_POSITIONS,
  type GearSetPosition,
} from "../models/GearSetPosition";
import { compareGearSets } from "../utils/compare";
import { GearSelect } from "./GearSelect";
import StatTable from "./StatTable";
import Card from "./Card";
import Modal from "./Modal";
import AmbuCape, { ambuCapes } from "./AmbuCape";
import { useAuth } from "../contexts/AuthContext";
import ApiService, {
  type CreateGearSetDto,
  type UpdateFullGearSetDto,
} from "../utils/apiService";
import { IoIosStats } from "react-icons/io";
import { TbTargetArrow } from "react-icons/tb";
import { RiSwordLine } from "react-icons/ri";
import { IoSparklesSharp } from "react-icons/io5";
import {
  FaCopy,
  FaShieldHalved,
  FaSuperpowers,
  FaFloppyDisk,
  FaFolderOpen,
  FaPlus,
  FaTrash,
} from "react-icons/fa6";
import { MdOutlinePets } from "react-icons/md";
import { GiBatteredAxe, GiPocketBow } from "react-icons/gi";
import { BsBriefcase } from "react-icons/bs";
import type { Job } from "../models/Job";
import type { GearStat } from "../models/GearStat";

interface Props {
  job: Job;
  subJob?: Job;
}

export function GearSetComparer({ job, subJob }: Props) {
  const { isAuthenticated } = useAuth();
  const [gearItems, setGearItems] = useState<GearItem[]>([]);
  const [savedGearSets, setSavedGearSets] = useState<GearSet[]>([]);

  // Initialize sets properly using helper function
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

  const [comparison, setComparison] = useState<
    { stat: GearStat; a: number; b: number; diff: number }[]
  >([]);

  // State for managing save/load UI
  const [showCreateNewDialog, setShowCreateNewDialog] = useState<{
    isSetA: boolean;
    show: boolean;
  }>({ isSetA: true, show: false });

  const [showLoadDialog, setShowLoadDialog] = useState<{
    isSetA: boolean;
    show: boolean;
  }>({ isSetA: true, show: false });

  const [customSetName, setCustomSetName] = useState("");
  const [isCreatingSet, setIsCreatingSet] = useState(false);

  useEffect(() => {
    if (!job) return;

    fetch(`/api/gear?job=${job.abbreviation}`)
      .then((res) => res.json())
      .then(setGearItems);

    // Initialize sets with all slots when job changes
    const initSet = (name: string): GearSet => ({
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

    setSetA(initSet("Set A"));
    setSetB(initSet("Set B"));
    setSetAAugments([]);
    setSetBAugments([]);

    // Load saved gear sets if authenticated
    if (isAuthenticated) {
      ApiService.getUserGearSets().then(setSavedGearSets).catch(console.error);
    }
  }, [job, isAuthenticated]);

  const getItemsBySlot = (
    currentSet: GearSet,
    slot: GearSetPosition
  ): GearItem[] => {
    let filterSlot: string = slot.toLowerCase();

    // Normalize dual-slot cases
    if (filterSlot === "ear1" || filterSlot === "ear2") filterSlot = "earrings";
    if (filterSlot === "ring1" || filterSlot === "ring2") filterSlot = "rings";

    let items = gearItems.filter((item) =>
      item.slots.map((s) => s.toLowerCase()).includes(filterSlot)
    );

    // If currentSet main is 2H, then sub should only include filterSlot = 'sub' and category = 'Grip'
    if (slot.toLowerCase() === "sub") {
      const mainItem = getItemAtPosition(currentSet, "Main");

      if (mainItem && mainItem.category === "2H") {
        items = items.filter((item) => item.category === "Grip");
      }

      if (mainItem && mainItem.category === "1H") {
        if (
          job.canDualWield ||
          subJob?.abbreviation === "NIN" ||
          subJob?.abbreviation === "DNC"
        ) {
          items = items.filter(
            (item) => item.category === "1H" || item.category === "Shield"
          );
        } else items = items.filter((item) => item.category === "Shield");
      }
    }

    if (slot.toLowerCase() === "ammo") {
      const rangeItem = getItemAtPosition(currentSet, "Range");

      if (rangeItem && rangeItem.category === "Gun") {
        items = items.filter((item) => item.category === "Bullet");
      } else if (rangeItem && rangeItem.category === "Crossbow") {
        items = items.filter((item) => item.category === "Bolt");
      } else if (rangeItem && rangeItem.category === "Bow") {
        items = items.filter((item) => item.category === "Arrow");
      }
    }

    return items;
  };

  useEffect(() => {
    // Create augmented gear sets for comparison
    const augmentedSetA = { ...setA };
    const augmentedSetB = { ...setB };

    // Add augments to Set A back item if it exists
    const backItemA = getItemAtPosition(setA, "Back");
    if (backItemA && setAAugments.length > 0) {
      const augmentedBackA = {
        ...backItemA,
        stats: [...backItemA.stats, ...setAAugments],
      };
      augmentedSetA.gearSetItems = setA.gearSetItems.map((slot) =>
        slot.position === "Back" ? { ...slot, gearItem: augmentedBackA } : slot
      );
      console.log("Augmented Set A Back Item:", augmentedBackA);
    }

    // Add augments to Set B back item if it exists
    const backItemB = getItemAtPosition(setB, "Back");
    if (backItemB && setBAugments.length > 0) {
      const augmentedBackB = {
        ...backItemB,
        stats: [...backItemB.stats, ...setBAugments],
      };
      augmentedSetB.gearSetItems = setB.gearSetItems.map((slot) =>
        slot.position === "Back" ? { ...slot, gearItem: augmentedBackB } : slot
      );
    }

    const result = compareGearSets(augmentedSetA, augmentedSetB);
    console.log("Comparison Result:", result);
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

  // Save/Load handlers
  const convertGearSetToDto = (gearSet: GearSet): CreateGearSetDto => {
    const gearSetSlots = gearSet.gearSetItems
      .filter((slot) => slot.gearItem) // Only include slots with actual items
      .map((slot) => ({
        gearItemId: slot.gearItem!.id,
        position: slot.position,
      }));

    return {
      name: gearSet.name,
      description: gearSet.description,
      jobId: job.id, // Use the current job from props
      gearSetSlots,
    };
  };

  const handleCreateNewSet = async (isSetA: boolean) => {
    const gearSet = isSetA ? setA : setB;

    setIsCreatingSet(true);

    try {
      // Create new gear set with custom name or default
      const setName = customSetName.trim() || gearSet.name;

      const gearSetDto = convertGearSetToDto(gearSet);
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

      setShowCreateNewDialog({ isSetA: false, show: false });
      setCustomSetName(""); // Clear the custom name
    } catch (error) {
      console.error("Failed to create new gear set:", error);
    } finally {
      setIsCreatingSet(false);
    }
  };

  const handleUpdateSet = async (isSetA: boolean) => {
    const gearSet = isSetA ? setA : setB;

    if (!gearSet.id) {
      console.error("Cannot update set without ID");
      return;
    }

    try {
      // Update existing gear set using full replacement
      const gearSetDto: UpdateFullGearSetDto = convertGearSetToDto(gearSet);

      await ApiService.updateFullGearSet(gearSet.id, gearSetDto);

      // Refresh saved gear sets list
      if (isAuthenticated) {
        const updatedSets = await ApiService.getUserGearSets();
        setSavedGearSets(updatedSets);
      }
    } catch (error) {
      console.error("Failed to update gear set:", error);
    }
  };

  const handleClearSet = (isSetA: boolean) => {
    const initSet = (name: string): GearSet => ({
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

    if (isSetA) {
      setSetA(initSet("Set A"));
      setSetAAugments([]);
    } else {
      setSetB(initSet("Set B"));
      setSetBAugments([]);
    }
  };

  const handleLoadGearSet = (isSetA: boolean, gearSet: GearSet) => {
    // Create a complete gear set with all positions
    const completeGearSet: GearSet = {
      ...gearSet,
      gearSetItems: ALL_GEAR_POSITIONS.map((position) => {
        // Find existing slot for this position
        const existingSlot = gearSet.gearSetItems.find(
          (slot) => slot.position === position
        );

        if (existingSlot) {
          // Use the existing slot if it exists
          return existingSlot;
        } else {
          // Create an empty slot for this position
          return {
            id: 0,
            gearSetId: gearSet.id || 0,
            gearItemId: 0,
            position,
            gearItem: null,
          };
        }
      }),
    };

    if (isSetA) {
      setSetA(completeGearSet);
    } else {
      setSetB(completeGearSet);
    }
    setShowLoadDialog({ isSetA: false, show: false });
    setCustomSetName(""); // Clear any pending custom name
  };

  const renderGearGrid = (isSetA: boolean) => {
    const currentSet = isSetA ? setA : setB;

    return (
      <div className="grid grid-cols-1 md:grid-cols-4">
        {ALL_GEAR_POSITIONS.map((slot) => {
          const options = getItemsBySlot(currentSet, slot);
          const selectedItem = getItemAtPosition(currentSet, slot);

          return (
            <GearSelect
              key={slot}
              label={slot}
              options={options}
              value={selectedItem || undefined}
              onChange={(item) => handleSelect(slot, item, isSetA)}
            />
          );
        })}
      </div>
    );
  };

  const statCategories = [
    { key: "Base", title: "Base Stats", icon: <IoIosStats /> },
    { key: "Weapon", title: "Weapon", icon: <GiBatteredAxe /> },
    { key: "Skill", title: "Skills", icon: <TbTargetArrow /> },
    { key: "Combat", title: "Combat", icon: <RiSwordLine /> },
    { key: "Ranged", title: "Ranged", icon: <GiPocketBow /> },
    { key: "Magic", title: "Magic", icon: <IoSparklesSharp /> },
    { key: "Defense", title: "Defense", icon: <FaShieldHalved /> },
    { key: "Pet", title: "Pet", icon: <MdOutlinePets /> },
    { key: "Utility", title: "Utility", icon: <FaSuperpowers /> },
    { key: "Job", title: "Job", icon: <BsBriefcase /> },
  ];

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
    const luaLines: string[] = [];
    for (const slot of ALL_GEAR_POSITIONS) {
      const item = getItemAtPosition(gearSet, slot);
      if (item) {
        if (slot === "Back" && augments.length > 0) {
          const augStr = augments.map((a) => `${a.name}+${a.value}`).join(", ");
          luaLines.push(`    ${slot}="${item.name}" -- augments: ${augStr},`);
        } else {
          luaLines.push(`    ${slot}="${item.name}",`);
        }
      }
    }
    const luaString = `{\n${luaLines.join("\n")}\n}`;
    navigator.clipboard.writeText(luaString);
  };

  return (
    <div>
      <div className="grid grid-cols-1 md:grid-cols-2 mb-4 gap-4">
        <Card className="relative">
          <div className="absolute top-6 right-6 flex gap-2">
            {isAuthenticated && (
              <>
                {!setA.gearSetItems.every((slot) => !slot.gearItem) && (
                  <button
                    className="text-gray-500 hover:text-green-600"
                    title="Create new gear set"
                    onClick={() =>
                      setShowCreateNewDialog({ isSetA: true, show: true })
                    }
                    type="button"
                  >
                    <FaPlus className="h-5 w-5" />
                  </button>
                )}
                {setA.id && (
                  <button
                    className="text-gray-500 hover:text-yellow-600"
                    title="Update current gear set"
                    onClick={() => handleUpdateSet(true)}
                    type="button"
                  >
                    <FaFloppyDisk className="h-5 w-5" />
                  </button>
                )}
                <button
                  className="text-gray-500 hover:text-blue-600"
                  title="Load gear set"
                  onClick={() =>
                    setShowLoadDialog({ isSetA: true, show: true })
                  }
                  type="button"
                >
                  <FaFolderOpen className="h-5 w-5" />
                </button>
              </>
            )}
            {!setA.gearSetItems.every((slot) => !slot.gearItem) && (
              <button
                className="text-gray-500 hover:text-red-600"
                title="Clear gear set"
                onClick={() => handleClearSet(true)}
                type="button"
              >
                <FaTrash className="h-5 w-5" />
              </button>
            )}
            {!setA.gearSetItems.every((slot) => !slot.gearItem) && (
              <button
                className="text-gray-500 hover:text-purple-600"
                title="Copy lua to clipboard"
                onClick={() => handleCopyLua(setA, setAAugments)}
                type="button"
              >
                <FaCopy className="h-5 w-5" />
              </button>
            )}
          </div>
          <h3 className="font-semibold mb-2">
            Set A{setA.id && setA.name !== "Set A" ? ` - ${setA.name}` : ""}
          </h3>
          {renderGearGrid(true)}
          {(() => {
            const backItem = getItemAtPosition(setA, "Back");
            return (
              backItem?.name &&
              ambuCapes.includes(backItem.name) && (
                <AmbuCape onAugmentChange={setSetAAugments} />
              )
            );
          })()}
        </Card>
        <Card className="relative">
          <div className="absolute top-6 right-6 flex gap-2">
            {isAuthenticated && (
              <>
          {!setB.gearSetItems.every((slot) => !slot.gearItem) && (
            <button
              className="text-gray-500 hover:text-green-600"
              title="Create new gear set"
              onClick={() =>
                setShowCreateNewDialog({ isSetA: false, show: true })
              }
              type="button"
            >
              <FaPlus className="h-5 w-5" />
            </button>
          )}
          {setB.id && (
            <button
              className="text-gray-500 hover:text-yellow-600"
              title="Update current gear set"
              onClick={() => handleUpdateSet(false)}
              type="button"
            >
              <FaFloppyDisk className="h-5 w-5" />
            </button>
          )}
          <button
            className="text-gray-500 hover:text-blue-600"
            title="Load gear set"
            onClick={() =>
              setShowLoadDialog({ isSetA: false, show: true })
            }
            type="button"
          >
            <FaFolderOpen className="h-5 w-5" />
          </button>
              </>
            )}
            {!setB.gearSetItems.every((slot) => !slot.gearItem) && (
              <button
          className="text-gray-500 hover:text-red-600"
          title="Clear gear set"
          onClick={() => handleClearSet(false)}
          type="button"
              >
          <FaTrash className="h-5 w-5" />
              </button>
            )}
            {!setB.gearSetItems.every((slot) => !slot.gearItem) && (
              <button
          className="text-gray-500 hover:text-purple-600"
          title="Copy lua to clipboard"
          onClick={() => handleCopyLua(setB, setBAugments)}
          type="button"
              >
          <FaCopy className="h-5 w-5" />
              </button>
            )}
          </div>
          <h3 className="font-semibold mb-2">
            Set B{setB.id && setB.name !== "Set B" ? ` - ${setB.name}` : ""}
          </h3>
          {renderGearGrid(false)}
          {(() => {
            const backItem = getItemAtPosition(setB, "Back");
            return (
              backItem?.name &&
              ambuCapes.includes(backItem.name) && (
          <AmbuCape onAugmentChange={setSetBAugments} />
              )
            );
          })()}
        </Card>
      </div>

      {comparison.length > 0 && (
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
      <Modal
        isOpen={showCreateNewDialog.show}
        onClose={() => {
          setShowCreateNewDialog({ isSetA: false, show: false });
          setCustomSetName("");
        }}
        size="md"
      >
        <div className="p-6">
          <h3 className="text-lg font-semibold mb-4 text-gray-900 dark:text-white">
            Create New Gear Set{" "}
            <span className="text-sm text-blue-500 dark:text-blue-300 ml-2">
              ({job.fullName})
            </span>
          </h3>

          <div className="mb-6">
            <label className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2">
              Gear Set Name
            </label>
            <input
              type="text"
              value={customSetName}
              onChange={(e) => setCustomSetName(e.target.value)}
              placeholder={`e.g. WAR Savage Blade Set`}
              className="w-full px-3 py-2 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-blue-500 bg-white dark:bg-gray-800 text-gray-900 dark:text-white"
              autoFocus
            />
          </div>

          <div className="flex justify-end gap-3 pt-4 border-t border-gray-200 dark:border-gray-600">
            <button
              onClick={() => {
                setShowCreateNewDialog({ isSetA: false, show: false });
                setCustomSetName("");
              }}
              disabled={isCreatingSet}
              className="px-4 py-2 text-gray-700 dark:text-gray-300 border border-gray-300 dark:border-gray-600 rounded-lg hover:bg-gray-50 dark:hover:bg-gray-700 focus:outline-none focus:ring-2 focus:ring-blue-500 transition-colors disabled:opacity-50 disabled:cursor-not-allowed"
            >
              Cancel
            </button>
            <button
              onClick={() => handleCreateNewSet(showCreateNewDialog.isSetA)}
              disabled={isCreatingSet}
              className="px-4 py-2 bg-blue-600 text-white rounded-lg hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-500 focus:ring-offset-2 transition-colors disabled:opacity-50 disabled:cursor-not-allowed"
            >
              {isCreatingSet ? (
                <span className="flex items-center">
                  <svg
                    className="animate-spin -ml-1 mr-2 h-4 w-4 text-white"
                    xmlns="http://www.w3.org/2000/svg"
                    fill="none"
                    viewBox="0 0 24 24"
                  >
                    <circle
                      className="opacity-25"
                      cx="12"
                      cy="12"
                      r="10"
                      stroke="currentColor"
                      strokeWidth="4"
                    ></circle>
                    <path
                      className="opacity-75"
                      fill="currentColor"
                      d="M4 12a8 8 0 018-8V0C5.373 0 0 5.373 0 12h4zm2 5.291A7.962 7.962 0 014 12H0c0 3.042 1.135 5.824 3 7.938l3-2.647z"
                    ></path>
                  </svg>
                  Creating...
                </span>
              ) : (
                "Create Gear Set"
              )}
            </button>
          </div>
        </div>
      </Modal>

      {/* Load Dialog */}
      <Modal
        isOpen={showLoadDialog.show}
        onClose={() => setShowLoadDialog({ isSetA: false, show: false })}
        size="md"
      >
        <div className="p-6">
          <h3 className="text-lg font-semibold mb-4 text-gray-900 dark:text-white">
            Load {showLoadDialog.isSetA ? "Set A" : "Set B"}{" "}
            <span className="text-sm text-blue-500 dark:text-blue-300 ml-2">
              ({job.fullName})
            </span>
          </h3>

          <div className="max-h-96 overflow-y-auto mb-6">
            {savedGearSets.filter((gearSet) => gearSet.jobId === job.id)
              .length === 0 ? (
              <div className="text-center py-8">
                <div className="text-gray-400 dark:text-gray-500 mb-2">
                  <FaFolderOpen className="h-12 w-12 mx-auto" />
                </div>
                <p className="text-gray-500 dark:text-gray-400">
                  No saved gear sets found for {job.fullName}.
                </p>
                <p className="text-sm text-gray-400 dark:text-gray-500 mt-1">
                  Save a gear set first to load it later.
                </p>
              </div>
            ) : (
              <div className="space-y-2">
                {savedGearSets
                  .filter((gearSet) => gearSet.jobId === job.id)
                  .map((gearSet) => (
                    <button
                      key={gearSet.id}
                      onClick={() =>
                        handleLoadGearSet(showLoadDialog.isSetA, gearSet)
                      }
                      className="block w-full text-left p-3 border border-gray-200 dark:border-gray-600 rounded-lg hover:bg-gray-50 dark:hover:bg-gray-700 hover:border-blue-300 dark:hover:border-blue-500 focus:outline-none focus:ring-2 focus:ring-blue-500 transition-colors"
                    >
                      <div className="font-medium text-gray-900 dark:text-white">
                        {gearSet.name}
                      </div>
                      {gearSet.description && (
                        <div className="text-sm text-gray-600 dark:text-gray-300 mt-1">
                          {gearSet.description}
                        </div>
                      )}
                    </button>
                  ))}
              </div>
            )}
          </div>

          <div className="flex justify-end pt-4 border-t border-gray-200 dark:border-gray-600">
            <button
              onClick={() => setShowLoadDialog({ isSetA: false, show: false })}
              className="px-4 py-2 text-gray-700 dark:text-gray-300 border border-gray-300 dark:border-gray-600 rounded-lg hover:bg-gray-50 dark:hover:bg-gray-700 focus:outline-none focus:ring-2 focus:ring-blue-500 transition-colors"
            >
              Cancel
            </button>
          </div>
        </div>
      </Modal>
    </div>
  );
}
