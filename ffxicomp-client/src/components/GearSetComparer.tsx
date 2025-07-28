import { useState, useEffect } from "react";
import type { GearItem } from "../models/GearItem";
import type { GearSet } from "../models/GearSet";
import { compareGearSets } from "../utils/Compare";

interface Props {
  gearItems: GearItem[];
  selectedJob: string;
}

export function GearSetComparer({ gearItems, selectedJob }: Props) {
  const [setA, setSetA] = useState<GearSet>({});
  const [setB, setSetB] = useState<GearSet>({});
  const [comparison, setComparison] = useState<
    { name: string; a: number; b: number; diff: number }[]
  >([]);

  useEffect(() => {
    const result = compareGearSets(setA, setB);
    setComparison(result);
  }, [setA, setB]);

  const headOptions = gearItems.filter(
    (item) =>
      item.slot === "Head" &&
      selectedJob &&
      item.gearItemJobs.some(
        (j) => j.jobName.toLowerCase() === selectedJob.toLowerCase()
      )
  );

  return (
    <div>
      <h2 className="text-xl font-bold mb-2">Gear Set Comparison</h2>

      <div className="flex gap-8 mb-6">
        <div>
          <label className="block font-semibold">Set A: Head</label>
          <select
            className="border p-2"
            onChange={(e) => {
              const item = gearItems.find(
                (g) => g.id === Number(e.target.value)
              );
              setSetA((prev) => ({ ...prev, head: item }));
            }}
            value={setA.head?.id ?? ""}
          >
            <option value="">Select Head</option>
            {headOptions.map((item) => (
              <option key={item.id} value={item.id}>
                {item.name}
              </option>
            ))}
          </select>
        </div>

        <div>
          <label className="block font-semibold">Set B: Head</label>
          <select
            className="border p-2"
            onChange={(e) => {
              const item = gearItems.find(
                (g) => g.id === Number(e.target.value)
              );
              setSetB((prev) => ({ ...prev, head: item }));
            }}
            value={setB.head?.id ?? ""}
          >
            <option value="">Select Head</option>
            {headOptions.map((item) => (
              <option key={item.id} value={item.id}>
                {item.name}
              </option>
            ))}
          </select>
        </div>
      </div>

      <table className="border w-full text-sm">
        <thead>
          <tr className="bg-gray-100">
            <th className="text-left p-2">Stat</th>
            <th className="text-right p-2">Set A</th>
            <th className="text-right p-2">Set B</th>
            <th className="text-right p-2">Diff</th>
          </tr>
        </thead>
        <tbody>
          {comparison.map((stat) => (
            <tr key={stat.name}>
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
                {stat.diff >= 0 ? "+" : ""}
                {stat.diff}
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
