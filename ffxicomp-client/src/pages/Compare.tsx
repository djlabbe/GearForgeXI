import { useState, useEffect } from "react";
import type { GearItem } from "../models/GearItem";
import { JobSelector } from "../components/JobSelector";
import { GearSetComparer } from "../components/GearSetComparer";

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

const ComparePage = () => {
  const [gearItems, setGearItems] = useState<GearItem[]>([]);
  const [selectedJob, setSelectedJob] = useState<string | null>(null);

  useEffect(() => {
    if (!selectedJob) return;

    fetch(`/api/gear/all?job=${selectedJob}`)
      .then((res) => res.json())
      .then(setGearItems);
  }, [selectedJob]);

  return (
    <div className="max-w-8xl mx-auto">
      <JobSelector
        selectedJob={selectedJob}
        onSelect={setSelectedJob}
        availableJobs={AVAILABLE_JOBS}
      />
      {selectedJob && <GearSetComparer gearItems={gearItems} />}
    </div>
  );
};

export default ComparePage;
