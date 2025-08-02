import type { GearItem, GearStat } from "../models/GearItem";
import type { GearSet } from "../models/GearSet";

export function getTotalStats(set: GearSet): Record<string, number> {
  const total: Record<string, number> = {};

  Object.values(set).forEach((item: GearItem) => {
    item?.stats.forEach((stat: GearStat) => {
      total[stat.name] = (total[stat.name] || 0) + stat.value;
    });
  });

  return total;
}

export function compareGearSets(setA: GearSet, setB: GearSet) {
  const statsA = getTotalStats(setA);
  const statsB = getTotalStats(setB);

  const allStatNames = new Set([
    ...Object.keys(statsA),
    ...Object.keys(statsB),
  ]);

  return Array.from(allStatNames).map((name) => ({
    name,
    a: statsA[name] ?? 0,
    b: statsB[name] ?? 0,
    diff: (statsB[name] ?? 0) - (statsA[name] ?? 0),
  }));
}
