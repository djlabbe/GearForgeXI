import { useState, useEffect } from "react";
import { useAppData } from "../contexts/AppDataContext";
import { useGearSetState } from "../hooks/useGearSetState";
import { ReactSelector } from "../components/ReactSelector";
import Card from "../components/Card";
import {
  BsLightningChargeFill,
  BsChevronDown,
  BsChevronRight,
  BsChevronUp,
} from "react-icons/bs";
import { CharacterSimulationService } from "../services";
import type { Job } from "../models/Job";
import type { GearSet } from "../models/GearSet";
import type {
  CharacterSimulationResponse,
  CalculateStatsRequest,
} from "../services";

export function Simulator() {
  const { jobs, loading: loadingAppData, error } = useAppData();
  const [selectedJob, setSelectedJob] = useState<Job | undefined>();
  const [masterLevel, setMasterLevel] = useState<number | undefined>(undefined);
  const [selectedSubJob, setSelectedSubJob] = useState<Job | undefined>();
  const [selectedGearSet, setSelectedGearSet] = useState<GearSet | undefined>();
  const [selectedRace, setSelectedRace] = useState<number | undefined>();
  const [isSimulating, setIsSimulating] = useState(false);
  const [simulationResult, setSimulationResult] =
    useState<CharacterSimulationResponse | null>(null);
  const [simulationError, setSimulationError] = useState<string | null>(null);
  const [expandedStats, setExpandedStats] = useState<Set<string>>(new Set());
  const [isFormCollapsed, setIsFormCollapsed] = useState(false);

  // Calculate sub job level based on master level: 49 + (masterLevel / 5)
  const subJobLevel =
    masterLevel !== undefined ? Math.floor(49 + masterLevel / 5) : 1;

  // Get gear sets for the selected job
  const { savedGearSets } = useGearSetState(selectedJob!, true);

  // Race options
  const raceOptions = [
    { value: 1, label: "Galka" },
    { value: 2, label: "Elvaan" },
    { value: 3, label: "Hume" },
    { value: 4, label: "Mithra" },
    { value: 5, label: "Tarutaru" },
  ];

  // Check if required fields are filled for submit button
  const canSubmit =
    selectedJob && masterLevel !== undefined && selectedGearSet && selectedRace;

  // Clear sub job if it matches the main job
  useEffect(() => {
    if (
      selectedJob &&
      selectedSubJob &&
      selectedJob.abbreviation === selectedSubJob.abbreviation
    ) {
      setSelectedSubJob(undefined);
    }
  }, [selectedJob, selectedSubJob]);

  const jobOptions =
    jobs?.map((job) => ({
      value: job.abbreviation,
      label: `${job.fullName} (${job.abbreviation})`,
    })) || [];

  // Filter options to prevent selecting the same job for both main and sub
  const availableSubJobOptions = jobOptions.filter(
    (option) => option.value !== selectedJob?.abbreviation
  );

  // Clear sub job if it's no longer available in the filtered options
  useEffect(() => {
    if (
      selectedSubJob &&
      !availableSubJobOptions.find(
        (opt) => opt.value === selectedSubJob.abbreviation
      )
    ) {
      setSelectedSubJob(undefined);
    }
  }, [availableSubJobOptions, selectedSubJob]);

  const handleJobChange = (option: any) => {
    setSelectedJob(jobs?.find((job) => job.abbreviation === option?.value));
    // Clear selected gear set when job changes
    setSelectedGearSet(undefined);
  };

  const handleSubJobChange = (option: any) => {
    setSelectedSubJob(jobs?.find((job) => job.abbreviation === option?.value));
  };

  const toggleStatExpansion = (statName: string) => {
    const newExpanded = new Set(expandedStats);
    if (newExpanded.has(statName)) {
      newExpanded.delete(statName);
    } else {
      newExpanded.add(statName);
    }
    setExpandedStats(newExpanded);
  };

  const formatStatValue = (value: number | null): string => {
    if (value === null) return "N/A";
    return value.toString();
  };

  const handleSubmit = async () => {
    if (!canSubmit) return;

    setIsSimulating(true);
    setSimulationError(null);
    setSimulationResult(null);

    try {
      const requestData: CalculateStatsRequest = {
        raceId: selectedRace!,
        mainJobId: selectedJob!.id,
        masterLevel: masterLevel!,
        subJobId: selectedSubJob?.id || null,
        subJobLevel: selectedSubJob ? subJobLevel : null,
        gearSetId: selectedGearSet!.id || null,
      };

      console.log("Sending simulation request:", requestData);

      const result = await CharacterSimulationService.calculateCharacterStats(
        requestData
      );
      setSimulationResult(result);
      setIsFormCollapsed(true); // Collapse form after successful response
      console.log("Simulation result:", result);
    } catch (error) {
      console.error("Simulation error:", error);
      setSimulationError(
        error instanceof Error ? error.message : "An unexpected error occurred"
      );
    } finally {
      setIsSimulating(false);
    }
  };

  return (
    <div className="max-w-6xl mx-auto">
      <div className="flex justify-between items-center mb-4">
        <h1 className="text-2xl font-bold text-gray-900 dark:text-white">
          Character Simulator
        </h1>
      </div>

      <Card className="mb-4">
        {/* Collapsible Header */}
        <div className="flex items-center justify-between mb-4">
          <h2 className="text-lg font-semibold text-gray-900 dark:text-white">
            Simulation Configuration
          </h2>
          <button
            onClick={() => setIsFormCollapsed(!isFormCollapsed)}
            className="p-2 hover:bg-gray-100 dark:hover:bg-gray-700 rounded-lg transition-colors"
            aria-label={isFormCollapsed ? "Expand form" : "Collapse form"}
          >
            {isFormCollapsed ? (
              <BsChevronDown className="h-5 w-5 text-gray-500" />
            ) : (
              <BsChevronUp className="h-5 w-5 text-gray-500" />
            )}
          </button>
        </div>

        {/* Collapsible Content */}
        {!isFormCollapsed && (
          <>
            {loadingAppData ? (
              <div className="text-gray-500">Loading...</div>
            ) : error ? (
              <div className="text-red-500">Error: {error}</div>
            ) : (
              <div className="space-y-6">
                {/* Form Controls in Clean 2-Column Layout */}
                <div className="space-y-4">
                  {/* Row 1: Main Job and Sub Job */}
                  <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
                    <div>
                      <label className="block font-semibold mb-2 text-gray-800 dark:text-gray-200">
                        Main Job *
                      </label>
                      <ReactSelector
                        value={jobOptions.find(
                          (opt) => opt.value === selectedJob?.abbreviation
                        )}
                        onChange={handleJobChange}
                        options={jobOptions}
                        placeholder="Select main job..."
                      />
                    </div>
                    <div>
                      <label className="block font-semibold mb-2 text-gray-800 dark:text-gray-200">
                        Sub Job
                      </label>
                      <ReactSelector
                        value={
                          selectedSubJob &&
                          availableSubJobOptions.find(
                            (opt) => opt.value === selectedSubJob.abbreviation
                          )
                            ? availableSubJobOptions.find(
                                (opt) =>
                                  opt.value === selectedSubJob.abbreviation
                              )
                            : null
                        }
                        onChange={handleSubJobChange}
                        options={availableSubJobOptions}
                        placeholder="Select sub job..."
                        isClearable
                      />
                    </div>
                  </div>

                  {/* Row 2: Race and Master Level */}
                  <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
                    <div>
                      <label className="block font-semibold mb-2 text-gray-800 dark:text-gray-200">
                        Race *
                      </label>
                      <ReactSelector
                        value={
                          selectedRace
                            ? raceOptions.find(
                                (race) => race.value === selectedRace
                              ) || null
                            : null
                        }
                        onChange={(option) => {
                          setSelectedRace(option?.value);
                        }}
                        options={raceOptions}
                        placeholder="Select a race..."
                        isClearable
                      />
                    </div>
                    <div>
                      <label className="block font-semibold mb-2 text-gray-800 dark:text-gray-200 flex items-center gap-1">
                        Master Level *
                        <div className="relative group">
                          <svg
                            className="w-4 h-4 text-gray-400 hover:text-gray-600 dark:text-gray-500 dark:hover:text-gray-300 cursor-help"
                            fill="currentColor"
                            viewBox="0 0 20 20"
                          >
                            <path
                              fillRule="evenodd"
                              d="M18 10a8 8 0 11-16 0 8 8 0 0116 0zm-8-3a1 1 0 00-.867.5 1 1 0 11-1.731-1A3 3 0 0113 8a3.001 3.001 0 01-2 2.83V11a1 1 0 11-2 0v-1a1 1 0 011-1 1 1 0 100-2zm0 8a1 1 0 100-2 1 1 0 000 2z"
                              clipRule="evenodd"
                            />
                          </svg>
                          <div className="absolute bottom-full left-1/2 transform -translate-x-1/2 mb-2 px-3 py-2 text-sm text-white bg-gray-900 rounded-lg opacity-0 group-hover:opacity-100 transition-opacity duration-200 pointer-events-none whitespace-nowrap z-10">
                            Sub Job Level is calculated based on master level
                            (assumed max)
                            <div className="absolute top-full left-1/2 transform -translate-x-1/2 w-0 h-0 border-l-4 border-r-4 border-t-4 border-transparent border-t-gray-900"></div>
                          </div>
                        </div>
                      </label>
                      <input
                        type="number"
                        min="0"
                        max="50"
                        value={masterLevel ?? ""}
                        onChange={(e) =>
                          setMasterLevel(
                            e.target.value
                              ? parseInt(e.target.value)
                              : undefined
                          )
                        }
                        className="w-full px-3 py-2 border border-gray-300 rounded-md bg-white text-gray-900 focus:outline-none focus:ring-2 focus:ring-blue-600 focus:border-blue-600 dark:bg-gray-700 dark:border-gray-600 dark:text-gray-100 dark:focus:ring-blue-600 dark:focus:border-blue-600"
                        placeholder="0-50"
                      />
                    </div>
                  </div>

                  {/* Row 3: Gear Set (Full Width) */}
                  <div>
                    <label className="block font-semibold mb-2 text-gray-800 dark:text-gray-200">
                      Gear Set *
                    </label>
                    <ReactSelector
                      value={
                        selectedGearSet
                          ? {
                              value: selectedGearSet.id?.toString() || "",
                              label: selectedGearSet.name,
                            }
                          : null
                      }
                      onChange={(option) => {
                        if (option) {
                          const gearSet = savedGearSets.find(
                            (set) => set.id?.toString() === option.value
                          );
                          setSelectedGearSet(gearSet);
                        } else {
                          setSelectedGearSet(undefined);
                        }
                      }}
                      options={savedGearSets.map((set) => ({
                        value: set.id?.toString() || "",
                        label: set.name,
                      }))}
                      placeholder={
                        selectedJob
                          ? "Select a gear set..."
                          : "Select main job first..."
                      }
                      isClearable
                      isDisabled={!selectedJob}
                    />
                  </div>

                  {/* Row 4: Submit Button (Full Width) */}
                  <div className="pt-2">
                    <button
                      onClick={handleSubmit}
                      disabled={!canSubmit || isSimulating}
                      className={`w-full px-8 py-4 rounded-xl font-semibold text-lg transition-all duration-300 transform flex items-center justify-center gap-3 shadow-lg ${
                        canSubmit && !isSimulating
                          ? "bg-gradient-to-r from-purple-600 to-blue-600 hover:from-purple-700 hover:to-blue-700 text-white cursor-pointer hover:scale-105 hover:shadow-xl active:scale-95"
                          : "bg-gray-300 text-gray-500 cursor-not-allowed dark:bg-gray-600 dark:text-gray-400 shadow-sm"
                      }`}
                    >
                      <BsLightningChargeFill
                        className={`h-5 w-5 ${
                          canSubmit && !isSimulating ? "animate-pulse" : ""
                        } ${isSimulating ? "animate-spin" : ""}`}
                      />
                      {isSimulating ? "Simulating..." : "Start Simulation"}
                    </button>
                  </div>
                </div>

                {/* Simulation Error */}
                {simulationError && (
                  <div className="bg-red-50 border border-red-200 rounded-lg p-4 dark:bg-red-900/20 dark:border-red-800">
                    <h3 className="text-lg font-semibold text-red-800 dark:text-red-200 mb-2">
                      Simulation Error
                    </h3>
                    <p className="text-red-700 dark:text-red-300">
                      {simulationError}
                    </p>
                  </div>
                )}
              </div>
            )}
          </>
        )}
      </Card>

      {/* Simulation Results Card */}
      {simulationResult && (
        <Card>
          <div className="space-y-6">
            <div>
              <h2 className="text-2xl font-bold text-gray-900 dark:text-white mb-6 border-b border-gray-200 dark:border-gray-700 pb-3">
                Simulation Results
              </h2>
            </div>

            {/* Character Overview */}
            <div>
              <h4 className="text-lg font-semibold text-gray-900 dark:text-white mb-4">
                Character Configuration
              </h4>
              <div className="bg-gray-50 dark:bg-gray-800 rounded-lg p-4">
                <div className="flex flex-col md:flex-row md:justify-between md:items-start gap-4">
                  <div className="grid grid-cols-1 md:grid-cols-2 gap-x-6 gap-y-2 text-gray-700 dark:text-gray-300">
                    <p>
                      <span className="font-medium">Main Job:</span>{" "}
                      {simulationResult.mainJob} (Level{" "}
                      {simulationResult.mainJobLevel})
                    </p>
                    {simulationResult.subJob && (
                      <p>
                        <span className="font-medium">Sub Job:</span>{" "}
                        {simulationResult.subJob} (Level{" "}
                        {simulationResult.subJobLevel})
                      </p>
                    )}
                    <p>
                      <span className="font-medium">Master Level:</span>{" "}
                      {simulationResult.masterLevel}
                    </p>
                    <p>
                      <span className="font-medium">Race:</span>{" "}
                      {simulationResult.race}
                    </p>
                    {simulationResult.gearSetName && (
                      <p>
                        <span className="font-medium">Gear Set:</span>{" "}
                        {simulationResult.gearSetName}
                      </p>
                    )}
                  </div>
                  <div className="text-sm text-gray-500 dark:text-gray-400">
                    <p>
                      Calculated:{" "}
                      {new Date(simulationResult.calculatedAt).toLocaleString()}
                    </p>
                  </div>
                </div>
              </div>
            </div>

            {/* Equipped Gear */}
            <div>
              <h4 className="text-lg font-semibold text-gray-900 dark:text-white mb-4">
                Equipped Gear
              </h4>
              <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4">
                {Object.entries(simulationResult.gear)
                  .filter(([_, itemName]) => itemName !== null)
                  .map(([slot, itemName]) => (
                    <div
                      key={slot}
                      className="bg-gray-50 dark:bg-gray-800 p-3 rounded-lg"
                    >
                      <div className="text-sm font-medium text-gray-600 dark:text-gray-400 capitalize">
                        {slot.replace(/([A-Z])/g, " $1").trim()}
                      </div>
                      <div className="text-gray-900 dark:text-white font-medium">
                        {itemName}
                      </div>
                    </div>
                  ))}
              </div>
            </div>

            {/* Derived Stats */}
            <div>
              <h4 className="text-lg font-semibold text-gray-900 dark:text-white mb-4">
                Derived Combat Stats
              </h4>
              <div className="grid grid-cols-2 md:grid-cols-3 lg:grid-cols-5 gap-4">
                <div className="bg-blue-50 dark:bg-blue-900/20 p-3 rounded-lg">
                  <div className="text-sm font-medium text-blue-600 dark:text-blue-400">
                    Max HP
                  </div>
                  <div className="text-lg font-bold text-blue-800 dark:text-blue-200">
                    {simulationResult.derivedStats.maxHp}
                  </div>
                </div>

                <div className="bg-green-50 dark:bg-green-900/20 p-3 rounded-lg">
                  <div className="text-sm font-medium text-green-600 dark:text-green-400">
                    Primary Accuracy
                  </div>
                  <div className="text-lg font-bold text-green-800 dark:text-green-200">
                    {simulationResult.derivedStats.primaryAccuracy}
                  </div>
                </div>
                <div className="bg-orange-50 dark:bg-orange-900/20 p-3 rounded-lg">
                  <div className="text-sm font-medium text-orange-600 dark:text-orange-400">
                    Auxiliary Accuracy
                  </div>
                  <div className="text-lg font-bold text-orange-800 dark:text-orange-200">
                    {simulationResult.derivedStats.auxiliaryAccuracy}
                  </div>
                </div>
                <div className="bg-cyan-50 dark:bg-cyan-900/20 p-3 rounded-lg">
                  <div className="text-sm font-medium text-cyan-600 dark:text-cyan-400">
                    Ranged Accuracy
                  </div>
                  <div className="text-lg font-bold text-cyan-800 dark:text-cyan-200">
                    {simulationResult.derivedStats.rangedAccuracy}
                  </div>
                </div>
                <div className="bg-emerald-50 dark:bg-emerald-900/20 p-3 rounded-lg">
                  <div className="text-sm font-medium text-emerald-600 dark:text-emerald-400">
                    Total Evasion
                  </div>
                  <div className="text-lg font-bold text-emerald-800 dark:text-emerald-200">
                    {simulationResult.derivedStats.totalEvasion}
                  </div>
                </div>
                <div className="bg-purple-50 dark:bg-purple-900/20 p-3 rounded-lg">
                  <div className="text-sm font-medium text-purple-600 dark:text-purple-400">
                    Max MP
                  </div>
                  <div className="text-lg font-bold text-purple-800 dark:text-purple-200">
                    {simulationResult.derivedStats.maxMp}
                  </div>
                </div>
                <div className="bg-red-50 dark:bg-red-900/20 p-3 rounded-lg">
                  <div className="text-sm font-medium text-red-600 dark:text-red-400">
                    Primary Attack
                  </div>
                  <div className="text-lg font-bold text-red-800 dark:text-red-200">
                    {simulationResult.derivedStats.primaryAttack}
                  </div>
                </div>

                <div className="bg-pink-50 dark:bg-pink-900/20 p-3 rounded-lg">
                  <div className="text-sm font-medium text-pink-600 dark:text-pink-400">
                    Auxiliary Attack
                  </div>
                  <div className="text-lg font-bold text-pink-800 dark:text-pink-200">
                    {simulationResult.derivedStats.auxiliaryAttack}
                  </div>
                </div>

                <div className="bg-indigo-50 dark:bg-indigo-900/20 p-3 rounded-lg">
                  <div className="text-sm font-medium text-indigo-600 dark:text-indigo-400">
                    Ranged Attack
                  </div>
                  <div className="text-lg font-bold text-indigo-800 dark:text-indigo-200">
                    {simulationResult.derivedStats.rangedAttack}
                  </div>
                </div>

                <div className="bg-yellow-50 dark:bg-yellow-900/20 p-3 rounded-lg">
                  <div className="text-sm font-medium text-yellow-600 dark:text-yellow-400">
                    Total Defense
                  </div>
                  <div className="text-lg font-bold text-yellow-800 dark:text-yellow-200">
                    {simulationResult.derivedStats.totalDefense}
                  </div>
                </div>
              </div>
            </div>

            {/* All Stats with Expandable Breakdown */}
            <div>
              <h4 className="text-lg font-semibold text-gray-900 dark:text-white mb-4">
                Character Statistics
                <span className="text-sm font-normal text-gray-500 dark:text-gray-400 ml-2">
                  (Click to expand breakdown)
                </span>
              </h4>
              <div className="space-y-2">
                {Object.entries(simulationResult.stats)
                  .sort(([a], [b]) => a.localeCompare(b))
                  .map(([statName, statValue]) => (
                    <div
                      key={statName}
                      className="border border-gray-200 dark:border-gray-700 rounded-lg"
                    >
                      <button
                        onClick={() => toggleStatExpansion(statName)}
                        className="w-full px-4 py-3 flex items-center justify-between hover:bg-gray-50 dark:hover:bg-gray-800 transition-colors"
                      >
                        <div className="flex items-center gap-3">
                          <span className="font-medium text-gray-900 dark:text-white">
                            {statName}
                          </span>
                          <span className="text-lg font-bold text-blue-600 dark:text-blue-400">
                            {formatStatValue(statValue)}
                          </span>
                        </div>
                        {expandedStats.has(statName) ? (
                          <BsChevronDown className="h-4 w-4 text-gray-400" />
                        ) : (
                          <BsChevronRight className="h-4 w-4 text-gray-400" />
                        )}
                      </button>

                      {expandedStats.has(statName) &&
                        simulationResult.statBreakdown[statName] && (
                          <div className="px-4 pb-3 border-t border-gray-200 dark:border-gray-700">
                            <div className="text-sm text-gray-600 dark:text-gray-400 mb-2 pt-3">
                              Stat Breakdown:
                            </div>
                            <div className="space-y-1">
                              {simulationResult.statBreakdown[statName].map(
                                (breakdown, index) => (
                                  <div
                                    key={index}
                                    className="flex justify-between text-sm"
                                  >
                                    <span className="text-gray-700 dark:text-gray-300">
                                      {breakdown.source}
                                    </span>
                                    <span
                                      className={`font-medium ${
                                        breakdown.value > 0
                                          ? "text-green-600 dark:text-green-400"
                                          : breakdown.value < 0
                                          ? "text-red-600 dark:text-red-400"
                                          : "text-gray-600 dark:text-gray-400"
                                      }`}
                                    >
                                      {breakdown.value > 0 ? "+" : ""}
                                      {breakdown.value}
                                    </span>
                                  </div>
                                )
                              )}
                            </div>
                          </div>
                        )}
                    </div>
                  ))}
              </div>
            </div>
          </div>
        </Card>
      )}
    </div>
  );
}
