import { useState, useEffect } from "react";
import type { GearItem } from "../models/GearItem";
import { ReactSelector } from "../components/ReactSelector";
import { GearSetComparer } from "../components/GearSetComparer";
import Card from "../components/Card";

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
    <>
      <Card className="mb-4">
        <label className="block font-semibold mb-2 text-gray-800 dark:text-gray-200">Job</label>
        <ReactSelector
          label="Job"
          selected={selectedJob}
          onSelect={setSelectedJob}
          options={AVAILABLE_JOBS}
        />
      </Card>
      {selectedJob && <GearSetComparer gearItems={gearItems} />}
    </>


  );
};

export default ComparePage;
