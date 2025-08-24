import type { GearStat } from "../models/GearStat";
import Card from "./Card";

interface Props {
  title: string;
  icon?: React.ReactNode;
  stats: Array<{ stat: GearStat; value: number | boolean }>;
}

export const SingleStatTable = ({ title, stats, icon }: Props) => {
  if (stats.length === 0) {
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
            <th className="text-left p-2 w-2/3">Stat</th>
            <th className="text-right p-2 w-1/3">Value</th>
          </tr>
        </thead>
        <tbody>
          {stats.map((statData) => {
            const isNumeric = typeof statData.value === 'number';
            return (
              <tr
                key={statData.stat.name}
                className="bg-gray-50 dark:bg-slate-800 border-t border-gray-400 dark:border-gray-700"
              >
                <td className="p-2">{statData.stat.displayName || statData.stat.name}</td>
                <td className="text-right p-2">
                  {isNumeric ? (
                    statData.value
                  ) : statData.value ? (
                    <span className="text-green-600 dark:text-green-400">✓</span>
                  ) : (
                    <span className="text-gray-400">✗</span>
                  )}
                </td>
              </tr>
            );
          })}
        </tbody>
      </table>
    </Card>
  );
};
