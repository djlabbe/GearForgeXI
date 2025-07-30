import { useEffect, useState } from "react";
import type { GearItem } from "../models/GearItem";

export function GearBrowser() {
  const [gearItems, setGearItems] = useState<GearItem[]>([]);
  const [filter, setFilter] = useState("");
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    setLoading(true);
    fetch("/api/gear/all")
      .then((res) => res.json())
      .then(setGearItems)
      .finally(() => setLoading(false));
  }, []);

  const filteredItems = gearItems.filter((item) =>
    item.name.toLowerCase().includes(filter.toLowerCase())
  );

  return (
    <div className="p-4">
      <h2 className="text-xl font-bold mb-4">All Gear Items</h2>
      <input
        type="text"
        placeholder="Filter by name..."
        value={filter}
        onChange={(e) => setFilter(e.target.value)}
        className="mb-4 p-2 border rounded w-full"
      />
      {loading ? (
        <div className="text-center text-gray-500 py-8">Loading...</div>
      ) : (
        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4">
          {filteredItems.map((item) => (
            <div key={item.id} className="border p-4 rounded shadow">
              <h3 className="font-semibold text-lg">{item.name}</h3>
              <p className="text-sm text-gray-600 mb-1">Slot: {item.slot}</p>
              {item.gearItemJobs.length > 0 && (
                <p className="text-sm text-gray-600 mb-2">
                  Jobs: {item.gearItemJobs.map((j) => j.jobName).join(", ")}
                </p>
              )}
              <ul className="text-sm">
                {item.gearStats.map((stat) => (
                  <li key={stat.name}>
                    {stat.name}:{" "}
                    <span className="font-semibold">{stat.value}</span>
                  </li>
                ))}
              </ul>
            </div>
          ))}
        </div>
      )}
    </div>
  );
}
