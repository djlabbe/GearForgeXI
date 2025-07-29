import { useEffect, useState } from "react";
import { GearSetComparer } from "./components/GearSetComparer";
import type { GearItem } from "./models/GearItem";
import { JobSelector } from "./components/JobSelector";

const AVAILABLE_JOBS = [
  "WAR",
  "MNK",
  "WHM",
  "BLM",
  "RDM",
  "THF",
  "PLD",
  "DRK",
  "BST",
  "BRD",
  "RNG",
  "SAM",
  "NIN",
  "DRG",
  "SMN",
  "BLU",
  "COR",
  "PUP",
  "DNC",
  "SCH",
  "GEO",
  "RUN",
];

function App() {
  const [gearItems, setGearItems] = useState<GearItem[]>([]);
  const [selectedJob, setSelectedJob] = useState<string | null>(null);

  useEffect(() => {
    if (!selectedJob) return;

    fetch(`/api/gear/all?job=${selectedJob}`)
      .then((res) => res.json())
      .then(setGearItems);
  }, [selectedJob]);

  return (
    <div className="p-4 max-w-8xl mx-auto">
      <h1 className="text-2xl font-bold mb-4">FFXI Gear Set Comparison</h1>
      <JobSelector
        selectedJob={selectedJob}
        onSelect={setSelectedJob}
        availableJobs={AVAILABLE_JOBS}
      />
      {selectedJob && <GearSetComparer gearItems={gearItems} />}
    </div>
  );
}

export default App;
