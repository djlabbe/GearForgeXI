import type { GearSet } from "../models/GearSet";
import type { GearStat } from "../models/GearStat";

export interface NumericStatComparison {
  stat: GearStat;
  a: number;
  b: number;
  diff: number;
  type: 'numeric';
}

export interface NonNumericStatComparison {
  stat: GearStat;
  aHasIt: boolean;
  bHasIt: boolean;
  type: 'non-numeric';
}

export type StatComparison = NumericStatComparison | NonNumericStatComparison;

export function getTotalStats(set: GearSet): {
  numericStats: Map<string, { stat: GearStat; value: number }>;
  nonNumericStats: Map<string, GearStat[]>;
} {
  const numericStats = new Map<string, { stat: GearStat; value: number }>();
  const nonNumericStats = new Map<string, GearStat[]>();

  set.gearSetItems.forEach((slot) => {
    slot.gearItem?.stats.forEach((stat: GearStat) => {
      if (stat.value !== null) {
        // Handle numeric stats
        const existing = numericStats.get(stat.name);
        if (existing) {
          existing.value += stat.value;
        } else {
          numericStats.set(stat.name, { stat, value: stat.value });
        }
      } else {
        // Handle non-numeric stats
        const existing = nonNumericStats.get(stat.name);
        if (existing) {
          existing.push(stat);
        } else {
          nonNumericStats.set(stat.name, [stat]);
        }
      }
    });
  });

  return { numericStats, nonNumericStats };
}

export function compareGearSets(setA: GearSet, setB: GearSet): StatComparison[] {
  const statsA = getTotalStats(setA);
  const statsB = getTotalStats(setB);

  const results: StatComparison[] = [];

  // Handle numeric stats
  const allNumericStatNames = new Set([
    ...statsA.numericStats.keys(),
    ...statsB.numericStats.keys(),
  ]);

  allNumericStatNames.forEach((name) => {
    const statA = statsA.numericStats.get(name);
    const statB = statsB.numericStats.get(name);
    const stat = statA?.stat || statB?.stat!;
    
    results.push({
      stat,
      a: statA?.value ?? 0,
      b: statB?.value ?? 0,
      diff: (statB?.value ?? 0) - (statA?.value ?? 0),
      type: 'numeric',
    });
  });

  // Handle non-numeric stats
  const allNonNumericStatNames = new Set([
    ...statsA.nonNumericStats.keys(),
    ...statsB.nonNumericStats.keys(),
  ]);

  allNonNumericStatNames.forEach((name) => {
    const statsInA = statsA.nonNumericStats.get(name);
    const statsInB = statsB.nonNumericStats.get(name);
    const stat = statsInA?.[0] || statsInB?.[0]!;
    
    results.push({
      stat,
      aHasIt: Boolean(statsInA && statsInA.length > 0),
      bHasIt: Boolean(statsInB && statsInB.length > 0),
      type: 'non-numeric',
    });
  });

  return results;
}
