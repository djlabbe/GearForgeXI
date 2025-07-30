import { useState, useEffect } from "react";
import type { GearItem } from "../models/GearItem";
import type { GearSet, GearSlot } from "../models/GearSet";
import { compareGearSets } from "../utils/compare";

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

  const handleSelect = (slot: GearSlot, value: string, isSetA: boolean) => {
    const updater = isSetA ? setSetA : setSetB;

    if (value === "") {
      updater((prev) => {
        const updated = { ...prev };
        updated[slot] = undefined;
        return updated;
      });
      return;
    }

    const item = gearItems.find((g) => g.id === Number(value));
    if (!item) return;

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
          const selectedId = currentSet[slot]?.id ?? "";

          return (
            <div key={slot} className="p-2">
              <label className="block capitalize mb-1">{slot}</label>
              <select
                className="border w-full"
                onChange={(e) => handleSelect(slot, e.target.value, isSetA)}
                value={selectedId}
              >
                <option value="">Select...</option>
                {options.map((item) => (
                  <option key={item.id} value={item.id}>
                    {item.name}
                  </option>
                ))}
              </select>
            </div>
          );
        })}
      </div>
    );
  };

  const coreStatNames = ["Str", "DEX", "AGI", "VIT", "INT", "MND", "CHR"];
  const meleeStatNames = [
    "Accuracy",
    "Attack",
    "DA",
    "TA",
    "QA",
    "GearHaste",
    "StoreTP",
    "WeaponSkillDamage",
  ];

  const renderStatTable = (
    title: string,
    stats: { name: string; a: number; b: number; diff: number }[]
  ) => {
    if (stats.length === 0) {
      return null;
    }

    return (
      <div className="w-1/2 mb-8 px-2">
        <h4 className="text-md font-semibold mb-2">{title}</h4>
        <table className="table-fixed w-full text-sm border border-gray-300">
          <thead>
            <tr className="bg-gray-100">
              <th className="text-left p-2 w-1/4">Stat</th>
              <th className="text-right p-2 w-1/4">Set A</th>
              <th className="text-right p-2 w-1/4">Set B</th>
              <th className="text-right p-2 w-1/4">Diff</th>
            </tr>
          </thead>
          <tbody>
            {stats.map((stat) => (
              <tr key={stat.name} className="border-t">
                <td className="p-2">{stat.name}</td>
                <td className="text-right p-2">{stat.a}</td>
                <td className="text-right p-2">{stat.b}</td>
                <td
                  className={`text-right p-2 ${
                    stat.diff > 0
                      ? "text-green-600"
                      : stat.diff < 0
                      ? "text-red-600"
                      : ""
                  }`}
                >
                  {stat.diff !== 0 && `${stat.diff > 0 ? "+" : ""}${stat.diff}`}
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    );
  };

  const coreStats = comparison
    .filter((c) => coreStatNames.includes(c.name.toUpperCase()))
    .slice()
    .sort((a, b) => a.name.localeCompare(b.name));

  const meleeStats = comparison
    .filter((c) => meleeStatNames.includes(c.name))
    .slice()
    .sort((a, b) => a.name.localeCompare(b.name));

  const otherStats = comparison
    .filter(
      (c) =>
        !coreStatNames.includes(c.name.toUpperCase()) &&
        !meleeStatNames.includes(c.name)
    )
    .slice()
    .sort((a, b) => a.name.localeCompare(b.name));

  return (
    <div>
      <div className="flex mb-8">
        <div className="w-1/2 border rounded p-6 mr-6">
          <h3 className="font-semibold mb-2">Set A</h3>
          {renderGearGrid(true)}
        </div>
        <div className="w-1/2 border rounded p-6">
          <h3 className="text-lg font-semibold mb-2">Set B</h3>
          {renderGearGrid(false)}
        </div>
      </div>

      <h3 className="text-lg font-semibold mb-2">Stat Comparison</h3>
      {comparison.length === 0 ? (
        <p className="text-gray-500 italic">Select gear to compare.</p>
      ) : (
        <div className="flex flex-wrap -mx-2">
          {renderStatTable("Core Stats", coreStats)}
          {renderStatTable("Melee", meleeStats)}
          {renderStatTable("Other Stats", otherStats)}
        </div>
      )}
    </div>
  );
}
