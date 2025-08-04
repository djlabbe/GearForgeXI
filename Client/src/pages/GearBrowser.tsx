import { useEffect, useState, useMemo } from "react";
import type { GearItem } from "../models/GearItem";
import Card from "../components/Card";
import { useJobs } from "../contexts/JobsContext";
import GearItemCard from "../components/GearItemCard";

function groupBySlot(items: GearItem[]): Record<string, GearItem[]> {
  return items.reduce<Record<string, GearItem[]>>((acc, item) => {
    item.slots.forEach((slot) => {
      const normalizedSlot = slot.toLowerCase(); // optional: lowercase for consistent keys
      if (!acc[normalizedSlot]) {
        acc[normalizedSlot] = [];
      }
      acc[normalizedSlot].push(item);
    });
    return acc;
  }, {});
}

const slots = [
  "Main",
  "Sub",
  "Range",
  "Ammo",
  "Head",
  "Neck",
  "Ear",
  "Body",
  "Hands",
  "Ring",
  "Back",
  "Waist",
  "Legs",
  "Feet",
];

export function GearBrowser() {
  const { jobs, loading: loadingJobs } = useJobs();

  const [gearItems, setGearItems] = useState<GearItem[]>([]);
  const [filter, setFilter] = useState("");
  const [loading, setLoading] = useState(true);
  const [selectedSlot, setSelectedSlot] = useState<string>("Main");
  const [selectedJob, setSelectedJob] = useState<string>("");

  useEffect(() => {
    setLoading(true);
    fetch("/api/gear")
      .then((res) => res.json())
      .then((items: GearItem[]) => {
        setGearItems(items);
      })
      .finally(() => setLoading(false));
  }, []);

  const grouped = useMemo(() => groupBySlot(gearItems), [gearItems]);

  const filteredItems = useMemo(() => {
    if (selectedSlot && grouped[selectedSlot.toLowerCase()]) {
      return grouped[selectedSlot.toLowerCase()].filter(
        (item) =>
          item.name.toLowerCase().includes(filter.toLowerCase()) &&
          (selectedJob === "" ||
            item.jobs.some((j) => j === selectedJob) ||
            item.jobs.length === 0)
      );
    }
    
    if (selectedSlot === "" && filter === "" && selectedJob === "") {
      return gearItems; // Show all items when no filters are selected
    }
    
    if (selectedSlot === "") {
      return gearItems.filter(
        (item) =>
          item.name.toLowerCase().includes(filter.toLowerCase()) &&
          (selectedJob === "" ||
            item.jobs.some((j) => j === selectedJob) ||
            item.jobs.length === 0)
      );
    }
    
    return [];
  }, [gearItems, grouped, selectedSlot, filter, selectedJob]);

  if (loading || loadingJobs) {
    return (
      <div className="flex items-center justify-center min-h-screen">
        <div className="text-gray-600 dark:text-gray-400">Loading...</div>
      </div>
    );
  }

  return (
    <div className="bg-white dark:bg-gray-900 min-h-screen">
      <Card className="mb-2">
        <h2 className="text-xl font-bold mb-4 text-gray-900 dark:text-gray-100">
          Filter
        </h2>
        <input
          type="text"
          placeholder="Filter by name..."
          value={filter}
          onChange={(e) => setFilter(e.target.value)}
          className="mb-4 p-2 border border-gray-300 dark:border-gray-700 rounded w-full bg-white dark:bg-gray-800 text-gray-900 dark:text-gray-100 placeholder-gray-400 dark:placeholder-gray-500"
        />
        <div className="flex space-x-2 mb-2">
          {/* <button
            onClick={() => setSelectedSlot("")}
            className={`px-3 py-1 rounded w-24 text-center cursor-pointer ${
              selectedSlot === ""
                ? "bg-blue-600 text-white"
                : "bg-gray-200 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
            }`}
          >
            All Slots
          </button> */}
          {slots.map((slot) => (
            <button
              key={slot}
              onClick={() => setSelectedSlot(slot)}
              className={`px-3 py-1 rounded w-24 text-center cursor-pointer ${
                selectedSlot === slot
                  ? "bg-blue-600 text-white"
                  : "bg-gray-200 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
              }`}
              style={{ minWidth: "6rem" }}
            >
              {slot}
            </button>
          ))}
        </div>
        <div className="flex space-x-2 mb-2 flex-wrap">
          <button
            onClick={() => setSelectedJob("")}
            className={`px-3 py-1 my-1 rounded w-24 cursor-pointer ${
              selectedJob === ""
                ? "bg-blue-600 text-white"
                : "bg-gray-200 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
            }`}
          >
            All Jobs
          </button>
          {jobs.map((job) => (
            <button
              key={job.abbreviation}
              onClick={() => setSelectedJob(job.abbreviation)}
              className={`px-3 py-1 my-1 rounded w-24 cursor-pointer ${
                selectedJob === job.abbreviation
                  ? "bg-blue-600 text-white"
                  : "bg-gray-200 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
              }`}
            >
              {job.abbreviation}
            </button>
          ))}
        </div>
      </Card>

      <div className="grid grid-cols-1 md:grid-cols-4 lg:grid-cols-6 gap-2">
        {filteredItems.map((item) => (
            <GearItemCard key={item.id} item={item} />
        ))}
      </div>
    </div>
  );
}
