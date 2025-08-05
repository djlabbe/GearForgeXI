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
import AmbuCape, { ambuCapes } from "./AmbuCape";
import { IoIosStats } from "react-icons/io";
import { TbTargetArrow } from "react-icons/tb";
import { RiSwordLine } from "react-icons/ri";
import { IoSparklesSharp } from "react-icons/io5";
import { FaCopy, FaShieldHalved, FaSuperpowers } from "react-icons/fa6";
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
  const [gearItems, setGearItems] = useState<GearItem[]>([]);

  // Initialize sets properly using helper function
  const [setA, setSetA] = useState<GearSet>(() => ({
    name: "Set A",
    slots: [],
  }));
  const [setAAugments, setSetAAugments] = useState<GearStat[]>([]);

  const [setB, setSetB] = useState<GearSet>(() => ({
    name: "Set B",
    slots: [],
  }));
  const [setBAugments, setSetBAugments] = useState<GearStat[]>([]);

  const [comparison, setComparison] = useState<
    { stat: GearStat; a: number; b: number; diff: number }[]
  >([]);

  useEffect(() => {
    if (!job) return;

    fetch(`/api/gear?job=${job.abbreviation}`)
      .then((res) => res.json())
      .then(setGearItems);

    // Initialize sets with all slots when job changes
    const initSet = (name: string): GearSet => ({
      name,
      slots: ALL_GEAR_POSITIONS.map((position) => ({
        position,
        gearItem: null,
      })),
    });

    setSetA(initSet("Set A"));
    setSetB(initSet("Set B"));
    setSetAAugments([]);
    setSetBAugments([]);
  }, [job]);

  const getItemsBySlot = (
    currentSet: GearSet,
    slot: GearSetPosition
  ): GearItem[] => {
    let filterSlot: string = slot.toLowerCase();

    // Normalize dual-slot cases
    if (filterSlot === "ear1" || filterSlot === "ear2") filterSlot = "ear";
    if (filterSlot === "ring1" || filterSlot === "ring2") filterSlot = "ring";

    let items = gearItems.filter((item) =>
      item.slots.map((s) => s.toLowerCase()).includes(filterSlot)
    );

    // If currentSet main is 2H, then sub should only include filterSlot = 'sub' and category = 'Grip'
    if (slot.toLowerCase() === "sub") {
      const mainItem = getItemAtPosition(currentSet, "main");

      if (mainItem && mainItem.category === "2H") {
        items = items.filter((item) => item.category === "Grip");
      }

      if (mainItem && mainItem.category === "1H") {
        if (job.canDualWield || subJob?.abbreviation === "NIN" || subJob?.abbreviation === "DNC") {
          items = items.filter(
            (item) => item.category === "1H" || item.category === "Shield"
          );
        } else items = items.filter((item) => item.category === "Shield");
      }
    }

    if (slot.toLowerCase() === "ammo") {
      const rangeItem = getItemAtPosition(currentSet, "range");

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
    const backItemA = getItemAtPosition(setA, "back");
    if (backItemA && setAAugments.length > 0) {
      const augmentedBackA = {
        ...backItemA,
        stats: [...backItemA.stats, ...setAAugments],
      };
      augmentedSetA.slots = setA.slots.map((slot) =>
        slot.position === "back" ? { ...slot, gearItem: augmentedBackA } : slot
      );
      console.log("Augmented Set A Back Item:", augmentedBackA);
    }

    // Add augments to Set B back item if it exists
    const backItemB = getItemAtPosition(setB, "back");
    if (backItemB && setBAugments.length > 0) {
      const augmentedBackB = {
        ...backItemB,
        stats: [...backItemB.stats, ...setBAugments],
      };
      augmentedSetB.slots = setB.slots.map((slot) =>
        slot.position === "back" ? { ...slot, gearItem: augmentedBackB } : slot
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
      if (slot === "back") {
        if (isSetA) {
          setSetAAugments([]);
        } else {
          setSetBAugments([]);
        }
      }
    },
    []
  );

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
        if (slot === "back" && augments.length > 0) {
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
          <button
            className="absolute top-6 right-6 text-gray-500 hover:text-blue-600"
            title="Copy lua to clipboard"
            onClick={() => handleCopyLua(setA, setAAugments)}
            type="button"
          >
            <FaCopy className="h-7 w-7" />
          </button>
          <h3 className="font-semibold mb-2">Set A</h3>
          {renderGearGrid(true)}
          {(() => {
            const backItem = getItemAtPosition(setA, "back");
            return (
              backItem?.name &&
              ambuCapes.includes(backItem.name) && (
                <AmbuCape onAugmentChange={setSetAAugments} />
              )
            );
          })()}
        </Card>
        <Card className="relative">
          <button
            className="absolute  top-6 right-6 text-gray-500 hover:text-blue-600"
            title="Copy lua to clipboard"
            onClick={() => handleCopyLua(setB, setBAugments)}
            type="button"
          >
            <FaCopy className="h-7 w-7" />
          </button>
          <h3 className="text-lg font-semibold mb-3">Set B</h3>
          {renderGearGrid(false)}
          {(() => {
            const backItem = getItemAtPosition(setB, "back");
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
    </div>
  );
}
