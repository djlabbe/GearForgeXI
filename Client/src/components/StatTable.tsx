import type { GearStat } from "../models/GearStat";
import Card from "./Card";

interface Props {
  title: string;
  icon?: React.ReactNode;
  statComparison: { stat: GearStat; a: number; b: number; diff: number }[];
}

const StatTable = ({ title, statComparison, icon }: Props) => {
  if (statComparison.length === 0) {
    return null;
  }
  return (
    <Card>
      <h4 className="text-md font-semibold mb-2 flex items-center gap-2">
        {icon && <span className="inline-flex">{icon}</span>}
        {title}
      </h4>
      <table className="table-fixed w-full text-sm border border-gray-300 dark:border-gray-700">
        <thead>
          <tr className="bg-gray-100 dark:bg-gray-900">
            <th className="text-left p-2 w-1/4">Stat</th>
            <th className="text-right p-2 w-1/4">Set A</th>
            <th className="text-right p-2 w-1/4">Set B</th>
            <th className="text-right p-2 w-1/4">Diff</th>
          </tr>
        </thead>
        <tbody>
          {statComparison.map((comparison) => {
            const isNegativeStat = comparison.a < 0 || comparison.b < 0;
            let diffClass = "";
            if (comparison.diff !== 0) {
              if (isNegativeStat) {
                diffClass =
                  comparison.diff > 0
                    ? "text-red-600 dark:text-red-400"
                    : comparison.diff < 0
                    ? "text-green-600 dark:text-green-400"
                    : "";
              } else {
                diffClass =
                  comparison.diff > 0
                    ? "text-green-600 dark:text-green-400"
                    : comparison.diff < 0
                    ? "text-red-600 dark:text-red-400"
                    : "";
              }
            }
            return (
              <tr
                key={comparison.stat.name}
                className="bg-gray-50 dark:bg-slate-800 border-t border-gray-400 dark:border-gray-700"
              >
                <td className="p-2">{comparison.stat.displayName || comparison.stat.name}</td>
                <td className="text-right p-2">{comparison.a}</td>
                <td className="text-right p-2">{comparison.b}</td>
                <td className={`text-right p-2 ${diffClass}`}>
                  {comparison.diff !== 0 && `${comparison.diff > 0 ? "+" : ""}${comparison.diff}`}
                </td>
              </tr>
            );
          })}
        </tbody>
      </table>
    </Card>
  );
};

export default StatTable;
