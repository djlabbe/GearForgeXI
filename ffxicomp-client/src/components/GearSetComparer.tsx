import { useState, useEffect, useCallback } from "react";
import type { GearItem, GearStat } from "../models/GearItem";
import type { GearSet, GearSlot } from "../models/GearSet";
import { compareGearSets } from "../utils/compare";
import {
  coreStatNames,
  combatStatNames,
  magicStatNames,
  defenseStatNames,
  statSkillNames,
  petStatNames,
} from "../utils/statGroups";
import { GearSelect } from "./GearSelect";
import StatTable from "./StatTable";
import Card from "./Card";
import AmbuCape from "./AmbuCape";
import { IoIosStats, IoMdHelpCircle } from "react-icons/io";
import { TbTargetArrow } from "react-icons/tb";
import { RiSwordLine } from "react-icons/ri";
import { IoSparklesSharp } from "react-icons/io5";
import { FaCopy, FaShieldHalved } from "react-icons/fa6";
import { MdOutlinePets } from "react-icons/md";
import type { Job } from "../models/Job";

interface Props {
  job: Job;
}

export function GearSetComparer({ job }: Props) {
  const [gearItems, setGearItems] = useState<GearItem[]>([]);
  const [setA, setSetA] = useState<GearSet>({});
  const [setB, setSetB] = useState<GearSet>({});
  const [setAAugments, setSetAAugments] = useState<GearStat[]>([]);
  const [setBAugments, setSetBAugments] = useState<GearStat[]>([]);
  const [comparison, setComparison] = useState<
    { name: string; a: number; b: number; diff: number }[]
  >([]);

  useEffect(() => {
    if (!job) return;

    fetch(`/api/gear?job=${job.abbreviation}`)
      .then((res) => res.json())
      .then(setGearItems);

    // When job changes, keep only items in SetA and SetB where item.jobs contains the new job
    setSetA((prev) => {
      const filtered: GearSet = {};
      for (const slot in prev) {
        const item = prev[slot as GearSlot];
        if (item && item.jobs && (item.jobs.includes(job.abbreviation) || item.jobs.length === 0)) {
          filtered[slot as GearSlot] = item;
        }
      }
      return filtered;
    });
    setSetB((prev) => {
      const filtered: GearSet = {};
      for (const slot in prev) {
        const item = prev[slot as GearSlot];
        if (item && item.jobs && (item.jobs.includes(job.abbreviation) || item.jobs.length === 0)) {
          filtered[slot as GearSlot] = item;
        }
      }
      return filtered;
    });

    setSetAAugments([]);
    setSetBAugments([]);
  }, [job]);

  const allSlots: GearSlot[] = [
    "main",
    "sub",
    "range",
    "ammo",
    "head",
    "neck",
    "ear1",
    "ear2",
    "body",
    "hands",
    "ring1",
    "ring2",
    "back",
    "waist",
    "legs",
    "feet",
  ];

  const ambuCapes = [
    "Cichol's Mantle",
    "Segomo's Mantle",
    "Alaunus's Cape",
    "Taranus's Cape",
    "Sucellos's Cape",
    "Toutatis's Cape",
    "Rudianos's Mantle",
    "Ankou's Mantle",
    "Artio's Mantle",
    "Intarabus's Cape",
    "Belenus's Cape",
    "Smertrios's Mantle",
    "Andartia's Mantle",
    "Brigantia's Mantle",
    "Campestres's Cape",
    "Rosmerta's Cape",
    "Camulus's Mantle",
    "Visucius's Mantle",
    "Senuna's Mantle",
    "Lugh's Cape",
    "Nantosuelta's Cape",
    "Ogma's cape",
  ];

  const getItemsBySlot = (slot: GearSlot): GearItem[] => {
    let filterSlot: string = slot.toLowerCase();

    // Normalize dual-slot cases
    if (filterSlot === "ear1" || filterSlot === "ear2") filterSlot = "ear";
    else if (filterSlot === "ring1" || filterSlot === "ring2")
      filterSlot = "ring";

    let items = gearItems.filter((item) =>
      item.slots.map((s) => s.toLowerCase()).includes(filterSlot)
    );

    // Special logic: sub can use main-hand 1H weapons too
    if (slot.toLowerCase() === "sub") {
      const mainItems = gearItems.filter((item) =>
        item.slots.map((s) => s.toLowerCase()).includes("main")
      );
      items = [...items, ...mainItems].sort((a, b) =>
        a.name.localeCompare(b.name)
      );
    }

    return items;
  };

  useEffect(() => {
    // Create augmented gear sets for comparison
    const augmentedSetA = { ...setA };
    const augmentedSetB = { ...setB };

    // Add augments to Set A back item if it exists
    if (augmentedSetA.back && setAAugments.length > 0) {
      augmentedSetA.back = {
        ...augmentedSetA.back,
        stats: [...augmentedSetA.back.stats, ...setAAugments],
      };
    }

    // Add augments to Set B back item if it exists
    if (augmentedSetB.back && setBAugments.length > 0) {
      augmentedSetB.back = {
        ...augmentedSetB.back,
        stats: [...augmentedSetB.back.stats, ...setBAugments],
      };
    }

    const result = compareGearSets(augmentedSetA, augmentedSetB);
    setComparison(result);
  }, [setA, setB, setAAugments, setBAugments]);

  const handleSelect = useCallback(
    (slot: GearSlot, item: GearItem | undefined, isSetA: boolean) => {
      const updater = isSetA ? setSetA : setSetB;

      updater((prev) => ({
        ...prev,
        [slot]: item,
      }));

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
        {allSlots.map((slot) => {
          const options = getItemsBySlot(slot);
          const selectedItem = currentSet[slot];

          return (
            <GearSelect
              key={slot}
              label={slot}
              options={options}
              value={selectedItem}
              onChange={(item) => handleSelect(slot, item, isSetA)}
            />
          );
        })}
      </div>
    );
  };

  const getStatsByNames = (names: string[]) => {
    return comparison
      .filter((c) => names.includes(c.name))
      .slice()
      .sort((a, b) => a.name.localeCompare(b.name));
  };

  const coreStats = getStatsByNames(coreStatNames);
  const meleeStats = getStatsByNames(combatStatNames);
  const magicStats = getStatsByNames(magicStatNames);
  const defenseStats = getStatsByNames(defenseStatNames);
  const statSkills = getStatsByNames(statSkillNames);
  const petStats = getStatsByNames(petStatNames);

  const otherStats = comparison
    .filter(
      (c) =>
        !coreStatNames.includes(c.name) &&
        !combatStatNames.includes(c.name) &&
        !defenseStatNames.includes(c.name) &&
        !magicStatNames.includes(c.name) &&
        !statSkillNames.includes(c.name) &&
        !petStatNames.includes(c.name)
    )
    .slice()
    .sort((a, b) => a.name.localeCompare(b.name));

  const handleCopyLua = (gearSet: GearSet, augments: GearStat[]) => {
    const luaLines: string[] = [];
    for (const slot of allSlots) {
      const item = gearSet[slot];
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
          {setA.back?.name && ambuCapes.includes(setA.back.name) && (
            <AmbuCape onAugmentChange={setSetAAugments} />
          )}
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
          {setB.back?.name && ambuCapes.includes(setB.back.name) && (
            <AmbuCape onAugmentChange={setSetBAugments} />
          )}
        </Card>
      </div>

      {comparison.length > 0 && (
        <div className="grid grid-cols-1 md:grid-cols-3 gap-4 mb-4">
          <StatTable
            title="Core Stats"
            stats={coreStats}
            icon={<IoIosStats />}
          />
          <StatTable
            title="Skills"
            stats={statSkills}
            icon={<TbTargetArrow />}
          />
          <StatTable title="Combat" stats={meleeStats} icon={<RiSwordLine />} />
          <StatTable
            title="Magic"
            stats={magicStats}
            icon={<IoSparklesSharp />}
          />
          <StatTable
            title="Defense"
            stats={defenseStats}
            icon={<FaShieldHalved />}
          />
          <StatTable title="Pet" stats={petStats} icon={<MdOutlinePets />} />
          <StatTable
            title="Other"
            stats={otherStats}
            icon={<IoMdHelpCircle />}
          />
        </div>
      )}
    </div>
  );
}
