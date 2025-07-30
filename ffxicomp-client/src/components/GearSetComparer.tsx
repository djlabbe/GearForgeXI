import { useState, useEffect } from "react";
import type { GearItem } from "../models/GearItem";
import type { GearSet, GearSlot } from "../models/GearSet";
import { compareGearSets } from "../utils/compare";
import { coreStatNames, combatStatNames, magicStatNames, defenseStatNames, statSkillNames, petStatNames } from "../utils/statGroups";
import { GearSelect } from "./GearSelect";
import StatTable from "./StatTable";
import Card from "./Card";

interface Props {
  gearItems: GearItem[];
}

export function GearSetComparer({ gearItems }: Props) {
  const [setA, setSetA] = useState<GearSet>({});
  const [setB, setSetB] = useState<GearSet>({});
  const [comparison, setComparison] = useState<
    { name: string; a: number; b: number; diff: number }[]
  >([]);

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

  const getItemsBySlot = (slot: GearSlot) => {
    let filterSlot: string = slot;
    if (slot === "ear1" || slot === "ear2") filterSlot = "ear";
    else if (slot === "ring1" || slot === "ring2") filterSlot = "ring";

    let items = gearItems.filter(
      (item) => item.slot.toLowerCase() === filterSlot.toLowerCase()
    );

    if (slot === "sub") {
      items = [
        ...items,
        ...gearItems.filter((item) => item.slot.toLowerCase() === "main"),
      ].sort((a, b) => a.name.localeCompare(b.name));
    }
    return items;
  };

  useEffect(() => {
    const result = compareGearSets(setA, setB);
    setComparison(result);
  }, [setA, setB]);

  const handleSelect = (slot: GearSlot, item: GearItem | undefined, isSetA: boolean) => {
    const updater = isSetA ? setSetA : setSetB;

    updater((prev) => ({
      ...prev,
      [slot]: item,
    }));
  };

  const renderGearGrid = (isSetA: boolean) => {
    const currentSet = isSetA ? setA : setB;

    return (
      <div className="grid grid-cols-4">
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
  }

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

  return (
    <div>
      <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
        <Card className="mb-3">
          <h3 className="font-semibold mb-2">Set A</h3>
          {renderGearGrid(true)}
        </Card>
        <Card className="mb-3">
          <h3 className="text-lg font-semibold mb-3">Set B</h3>
          {renderGearGrid(false)}
        </Card>
      </div>


      <div className="grid grid-cols-1 md:grid-cols-3 gap-3">
        <StatTable title="Core Stats" stats={coreStats} />
        <StatTable title="Skills" stats={statSkills} />
        <StatTable title="Combat" stats={meleeStats} />
        <StatTable title="Magic" stats={magicStats} />
        <StatTable title="Defense" stats={defenseStats} />
        <StatTable title="Pet" stats={petStats} />
        <StatTable title="Other" stats={otherStats} />
      </div>
    </div>
  );
}
