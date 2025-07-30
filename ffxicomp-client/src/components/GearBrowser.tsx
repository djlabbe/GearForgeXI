import { useEffect, useState } from "react";
import type { GearItem } from "../models/GearItem";
import Card from "./Card";

function groupBySlot(items: GearItem[]) {
  return items.reduce<Record<string, GearItem[]>>((acc, item) => {
    acc[item.slot] = acc[item.slot] || [];
    acc[item.slot].push(item);
    return acc;
  }, {});
}

function getAllJobs(items: GearItem[]) {
  const jobs = new Set<string>();
  items.forEach((item) => {
    item.gearItemJobs.forEach((j) => jobs.add(j.jobName));
  });
  return Array.from(jobs).sort();
}

export function GearBrowser() {
  const [gearItems, setGearItems] = useState<GearItem[]>([]);
  const [filter, setFilter] = useState("");
  const [loading, setLoading] = useState(true);
  const [selectedSlot, setSelectedSlot] = useState<string>("");
  const [selectedJob, setSelectedJob] = useState<string>("");

  useEffect(() => {
    setLoading(true);
    fetch("/api/gear/all")
      .then((res) => res.json())
      .then((items: GearItem[]) => {
        setGearItems(items);
        // Set default selected slot to the first slot found
        const slots = Array.from(new Set(items.map((i: GearItem) => i.slot.toString())));
        setSelectedSlot(slots[0] || "");
      })
      .finally(() => setLoading(false));
  }, []);

  const grouped = groupBySlot(gearItems);
  const slots = Object.keys(grouped);
  const jobs = getAllJobs(gearItems);

  const filteredItems =
    selectedSlot && grouped[selectedSlot]
      ? grouped[selectedSlot].filter((item) =>
          item.name.toLowerCase().includes(filter.toLowerCase()) &&
          (selectedJob === "" ||
            item.gearItemJobs.some((j) => j.jobName === selectedJob))
        )
      : [];

  return (
    <div className="bg-white dark:bg-gray-900 min-h-screen">
      <Card className="mb-2">
        <h2 className="text-xl font-bold mb-4 text-gray-900 dark:text-gray-100">Filter</h2>
        <input
          type="text"
          placeholder="Filter by name..."
          value={filter}
          onChange={(e) => setFilter(e.target.value)}
          className="mb-4 p-2 border border-gray-300 dark:border-gray-700 rounded w-full bg-white dark:bg-gray-800 text-gray-900 dark:text-gray-100 placeholder-gray-400 dark:placeholder-gray-500"
        />
        <div className="flex space-x-2 mb-2">
          {slots.map((slot) => (
            <button
              key={slot}
              onClick={() => setSelectedSlot(slot)}
              className={`px-4 py-2 rounded ${selectedSlot === slot
                ? "bg-blue-600 text-white"
                : "bg-gray-200 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
                }`}
            >
              {slot}
            </button>
          ))}
        </div>
        <div className="flex space-x-2 mb-2 flex-wrap">
          <button
            onClick={() => setSelectedJob("")}
            className={`px-3 py-1 rounded ${selectedJob === ""
              ? "bg-blue-600 text-white"
              : "bg-gray-200 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
              }`}
          >
            All Jobs
          </button>
          {jobs.map((job) => (
            <button
              key={job}
              onClick={() => setSelectedJob(job)}
              className={`px-3 py-1 rounded ${selectedJob === job
                ? "bg-blue-600 text-white"
                : "bg-gray-200 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
                }`}
            >
              {job}
            </button>
          ))}
        </div>
      </Card>

      <div className="grid grid-cols-1 md:grid-cols-4 lg:grid-cols-6 gap-2">
        {filteredItems.map((item) => (
          <Card key={item.id}>
            <h3 className="font-semibold text-lg text-gray-900 dark:text-gray-100">{item.name}</h3>
            <p className="text-sm text-gray-600 dark:text-gray-400 mb-1">Slot: {item.slot}</p>
            {item.gearItemJobs.length > 0 && (
              <p className="text-sm text-gray-600 dark:text-gray-400 mb-2">
                Jobs: {item.gearItemJobs.map((j) => j.jobName).join(", ")}
              </p>
            )}
            <ul className="text-sm">
              {item.gearStats.map((stat) => (
                <li key={stat.name} className="text-gray-800 dark:text-gray-200">
                  {stat.name}:{" "}
                  <span className="font-semibold text-gray-900 dark:text-gray-100">{stat.value}</span>
                </li>
              ))}
            </ul>
          </Card>
        ))}
      </div>
    </div>
  );
}
