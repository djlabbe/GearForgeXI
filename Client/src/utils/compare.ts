import type { GearSet } from "../models/GearSet";
import type { GearStat } from "../models/GearStat";

export function getTotalStats(set: GearSet): Map<string, { stat: GearStat; value: number }> {
  const total = new Map<string, { stat: GearStat; value: number }>();

  set.gearSetItems.forEach((slot) => {
    slot.gearItem?.stats.forEach((stat: GearStat) => {
      const existing = total.get(stat.name);
      if (existing) {
        existing.value += stat.value;
      } else {
        total.set(stat.name, { stat, value: stat.value });
      }
    });
  });

  return total;
}

export function compareGearSets(setA: GearSet, setB: GearSet) {
  const statsA = getTotalStats(setA);
  const statsB = getTotalStats(setB);

  const allStatNames = new Set([
    ...statsA.keys(),
    ...statsB.keys(),
  ]);

  return Array.from(allStatNames).map((name) => {
    const statA = statsA.get(name);
    const statB = statsB.get(name);
    const stat = statA?.stat || statB?.stat!;
    
    return {
      stat,
      a: statA?.value ?? 0,
      b: statB?.value ?? 0,
      diff: (statB?.value ?? 0) - (statA?.value ?? 0),
    };
  });
}
