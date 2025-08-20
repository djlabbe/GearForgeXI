import { useState, useEffect } from "react";
import { AgGridReact } from "ag-grid-react";
import { themeAlpine } from "ag-grid-community";
import { colorSchemeDarkBlue } from "ag-grid-community";
import { useAuth } from "../contexts/AuthContext";
import { RaceConfigurationService, StatsService } from "../services";
import type { Stat } from "../models/Stat";
import type {
  RaceConfiguration,
  CreateRaceConfigurationDto,
  CreateRaceBaseStatDto,
} from "../models/RaceConfiguration";
import ConfirmationModal from "../components/ConfirmationModal";
import Modal from "../components/Modal";
import type {
  CellValueChangedEvent,
  ColDef,
  ICellRendererParams,
} from "ag-grid-community";

const themeDarkBlue = themeAlpine.withPart(colorSchemeDarkBlue);

export function RaceConfigurations() {
  const { isAuthenticated, isAdmin } = useAuth();
  const [baseStats, setBaseStats] = useState<Stat[]>([]);
  const [loadingBaseStats, setLoadingBaseStats] = useState(true);
  const [raceConfigurations, setRaceConfigurations] = useState<
    RaceConfiguration[]
  >([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [quickFilterText, setQuickFilterText] = useState("");
  const isDarkMode = window.matchMedia("(prefers-color-scheme: dark)").matches;

  // Modal states
  const [showCreateModal, setShowCreateModal] = useState(false);
  const [showDeleteModal, setShowDeleteModal] = useState(false);
  const [showStatsModal, setShowStatsModal] = useState(false);
  const [isCreatingRace, setIsCreatingRace] = useState(false);

  // Form states
  const [selectedRace, setSelectedRace] = useState<RaceConfiguration | null>(
    null
  );

  // Form data
  const [createForm, setCreateForm] = useState<CreateRaceConfigurationDto>({
    name: "",
    abbreviation: "",
  });

  // Stats editing state
  const [editingStats, setEditingStats] = useState<{
    [key: number]: number | null;
  }>({});
  const [isUpdatingStats, setIsUpdatingStats] = useState(false);

  useEffect(() => {
    if (isAuthenticated) {
      loadData();
      loadBaseStats();
    }
  }, [isAuthenticated]);

  const loadBaseStats = async () => {
    try {
      setLoadingBaseStats(true);
      const stats = await StatsService.getBaseStats();
      setBaseStats(stats);
    } catch (err) {
      console.error("Failed to load base stats:", err);
      setError("Failed to load base stats");
    } finally {
      setLoadingBaseStats(false);
    }
  };

  const updateRace = async (race: RaceConfiguration) => {
    try {
      const updatedRace = await RaceConfigurationService.updateRaceConfiguration({
        id: race.id,
        name: race.name,
        abbreviation: race.abbreviation,
      });
      return updatedRace;
    } catch (error) {
      console.error("Error updating race:", error);
      throw error;
    }
  };

  const loadData = async () => {
    try {
      setLoading(true);
      setError(null);
      const racesData = await RaceConfigurationService.getRaceConfigurations();
      setRaceConfigurations(racesData);
    } catch (err) {
      setError(err instanceof Error ? err.message : "Failed to load data");
    } finally {
      setLoading(false);
    }
  };

  const onCellValueChanged = async (
    event: CellValueChangedEvent<RaceConfiguration>
  ) => {
    const updatedStat = event.data;

    try {
      await updateRace(updatedStat);
      console.log("Race updated successfully");

      // Flash the cell green to indicate successful save
      event.api.flashCells({
        rowNodes: [event.node],
        columns: [event.column.getColId()],
      });
    } catch {
      // Revert the change if the update failed
      event.node.setData(event.oldValue);
      setError("Failed to update. Please try again.");
    }
  };

  const handleCreateRace = async () => {
    setIsCreatingRace(true);
    try {
      const newRace = await RaceConfigurationService.createRaceConfiguration(createForm);
      setShowCreateModal(false);
      setCreateForm({ name: "", abbreviation: "" });

      // Add the new race to local state if API returns it
      if (newRace) {
        setRaceConfigurations((prevRaces) => [...prevRaces, newRace]);
      } else {
        // If API doesn't return the new race, reload data
        await loadData();
      }
    } catch (err) {
      setError(
        err instanceof Error
          ? err.message
          : "Failed to create race configuration"
      );
    } finally {
      setIsCreatingRace(false);
    }
  };

  const handleDeleteRace = async () => {
    if (!selectedRace) return;
    try {
      await RaceConfigurationService.deleteRaceConfiguration(selectedRace.id);
      setShowDeleteModal(false);

      // Remove the race from local state
      setRaceConfigurations((prevRaces) =>
        prevRaces.filter((r) => r.id !== selectedRace.id)
      );
      setSelectedRace(null);
    } catch (err) {
      setError(
        err instanceof Error
          ? err.message
          : "Failed to delete race configuration"
      );
    }
  };

  const openDeleteModal = (race: RaceConfiguration) => {
    setSelectedRace(race);
    setShowDeleteModal(true);
  };

  const openStatsModal = (race: RaceConfiguration) => {
    setSelectedRace(race);
    // Initialize editing stats with current values for only the main stats
    const currentStats: { [key: number]: number | null } = {};
    baseStats.forEach((stat) => {
      const existingStat = race.raceBaseStats.find(
        (rs) => rs.statId === stat.id
      );
      currentStats[stat.id] = existingStat ? existingStat.value : null;
    });
    setEditingStats(currentStats);
    setShowStatsModal(true);
  };

  const handleSaveStats = async () => {
    if (!selectedRace) return;

    setIsUpdatingStats(true);
    try {
      // Keep track of changes to update local state
      const updatedRaceBaseStats = [...selectedRace.raceBaseStats];

      // Process each stat
      for (const statId in editingStats) {
        const newValue = editingStats[parseInt(statId)];
        const existingStatIndex = updatedRaceBaseStats.findIndex(
          (rs) => rs.statId === parseInt(statId)
        );

        if (newValue === null || newValue === 0) {
          // Delete the stat if it exists and value is null/0
          if (existingStatIndex !== -1) {
            await RaceConfigurationService.deleteRaceBaseStat(
              selectedRace.id,
              parseInt(statId)
            );
            updatedRaceBaseStats.splice(existingStatIndex, 1);
          }
        } else {
          // Update or create the stat
          if (existingStatIndex !== -1) {
            await RaceConfigurationService.updateRaceBaseStat(
              selectedRace.id,
              parseInt(statId),
              newValue
            );
            updatedRaceBaseStats[existingStatIndex] = {
              ...updatedRaceBaseStats[existingStatIndex],
              value: newValue,
            };
          } else {
            const createDto: CreateRaceBaseStatDto = {
              statId: parseInt(statId),
              value: newValue,
            };
            await RaceConfigurationService.addRaceBaseStat(selectedRace.id, createDto);

            // Find the stat to add the complete object
            const stat = baseStats.find((s) => s.id === parseInt(statId));
            if (stat) {
              updatedRaceBaseStats.push({
                id: 0, // Temporary ID, will be correct on next full reload if needed
                raceConfigurationId: selectedRace.id,
                statId: parseInt(statId),
                stat: stat,
                value: newValue,
              });
            }
          }
        }
      }

      // Update local state instead of reloading all data
      setRaceConfigurations((prevRaces) =>
        prevRaces.map((race) =>
          race.id === selectedRace.id
            ? { ...race, raceBaseStats: updatedRaceBaseStats }
            : race
        )
      );

      setShowStatsModal(false);
      setSelectedRace(null);
      setEditingStats({});
    } catch (err) {
      setError(err instanceof Error ? err.message : "Failed to update stats");
    } finally {
      setIsUpdatingStats(false);
    }
  };

  const handleCancelStats = () => {
    if (isUpdatingStats) return; // Don't allow canceling while updating
    setShowStatsModal(false);
    setSelectedRace(null);
    setEditingStats({});
  };

  const columnDefs: ColDef<RaceConfiguration>[] = [
    {
      headerName: "ID",
      field: "id",
      sortable: true,
      filter: true,
      width: 80,
      editable: false,
    },
    {
      headerName: "Name",
      field: "name",
      sortable: true,
      filter: true,
      width: 150,
      editable: isAdmin,
      enableCellChangeFlash: true,
    },
    {
      headerName: "Abbreviation",
      field: "abbreviation",
      sortable: true,
      filter: true,
      width: 150,
      editable: isAdmin,
      enableCellChangeFlash: true,
    },
    {
      headerName: "Actions",
      width: 180,
      sortable: false,
      filter: false,
      editable: false,
      cellRenderer: (params: ICellRendererParams<RaceConfiguration>) => {
        const race = params.data;
        if (!race) return null;

        return (
          <div className="flex justify-center items-center h-full space-x-2">
            {isAdmin && (
              <>
                <button
                  onClick={() => openStatsModal(race)}
                  className="p-1 text-blue-500 hover:text-blue-600 hover:bg-blue-50 dark:hover:bg-blue-900/20 rounded transition-colors duration-200"
                  title="Edit Base Stats"
                >
                  <svg
                    className="h-4 w-4"
                    fill="none"
                    stroke="currentColor"
                    viewBox="0 0 24 24"
                  >
                    <path
                      strokeLinecap="round"
                      strokeLinejoin="round"
                      strokeWidth={2}
                      d="M11 3.055A9.001 9.001 0 1020.945 13H11V3.055z"
                    />
                    <path
                      strokeLinecap="round"
                      strokeLinejoin="round"
                      strokeWidth={2}
                      d="M20.488 9H15V3.512A9.025 9.025 0 0120.488 9z"
                    />
                  </svg>
                </button>
                <button
                  onClick={() => openDeleteModal(race)}
                  className="p-1 text-red-500 hover:text-red-600 hover:bg-red-50 dark:hover:bg-red-900/20 rounded transition-colors duration-200"
                  title={`Delete ${race.name}`}
                >
                  <svg
                    className="h-4 w-4"
                    fill="none"
                    stroke="currentColor"
                    viewBox="0 0 24 24"
                  >
                    <path
                      strokeLinecap="round"
                      strokeLinejoin="round"
                      strokeWidth={2}
                      d="M19 7l-.867 12.142A2 2 0 0116.138 21H7.862a2 2 0 01-1.995-1.858L5 7m5 4v6m4-6v6m1-10V4a1 1 0 00-1-1h-4a1 1 0 00-1 1v3M4 7h16"
                    />
                  </svg>
                </button>
              </>
            )}
          </div>
        );
      },
    },
  ];

  if (!isAuthenticated) {
    return (
      <div className="space-y-4">
        <div className="bg-red-50 dark:bg-red-900/20 border border-red-200 dark:border-red-800 rounded-lg p-6 text-center">
          <h1 className="text-2xl font-bold mb-4 text-red-800 dark:text-red-200">
            Access Denied
          </h1>
          <p className="text-red-700 dark:text-red-300">
            You must be logged in to manage race configurations.
          </p>
        </div>
      </div>
    );
  }

  if (loading || loadingBaseStats) {
    return (
      <div className="space-y-4">
        <div className="flex justify-center items-center p-8">
          <div className="animate-spin rounded-full h-8 w-8 border-b-2 border-blue-600"></div>
        </div>
      </div>
    );
  }

  return (
    <div className="space-y-4">
      {/* Header with Create Button */}
      <div className="flex justify-between items-center">
        <h1 className="text-2xl font-bold text-gray-900 dark:text-white">
          Race Configurations
        </h1>
        {isAdmin && (
          <button
            onClick={() => setShowCreateModal(true)}
            className="px-4 py-2 bg-blue-600 hover:bg-blue-700 text-white rounded-lg transition-colors duration-200 font-medium cursor-pointer"
          >
            Create New Race
          </button>
        )}
      </div>

      {/* Error Message */}
      {error && (
        <div className="bg-red-50 dark:bg-red-900/20 border border-red-200 dark:border-red-800 text-red-700 dark:text-red-200 px-4 py-3 rounded-lg">
          {error}
        </div>
      )}

      {/* Quick Filter */}
      <div className="flex items-center space-x-4">
        <div className="flex-1">
          <div className="relative">
            <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
              <svg
                className="h-4 w-4 text-gray-400"
                fill="none"
                stroke="currentColor"
                viewBox="0 0 24 24"
              >
                <path
                  strokeLinecap="round"
                  strokeLinejoin="round"
                  strokeWidth={2}
                  d="M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z"
                />
              </svg>
            </div>
            <input
              type="text"
              id="quick-filter"
              value={quickFilterText}
              onChange={(e) => setQuickFilterText(e.target.value)}
              placeholder="Filter races by name or abbreviation..."
              className="w-full pl-10 p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
              autoComplete="off"
            />
            {quickFilterText && (
              <button
                type="button"
                onClick={() => setQuickFilterText("")}
                className="absolute inset-y-0 right-0 pr-3 flex items-center text-gray-400 hover:text-gray-600 dark:hover:text-gray-300"
              >
                <svg
                  className="h-4 w-4"
                  fill="none"
                  stroke="currentColor"
                  viewBox="0 0 24 24"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    strokeWidth={2}
                    d="M6 18L18 6M6 6l12 12"
                  />
                </svg>
              </button>
            )}
          </div>
        </div>
      </div>

      {/* AG Grid */}
      <div
        className={`ag-theme-alpine dark:ag-theme-alpine-dark rounded-xl shadow-md border border-gray-200 dark:border-gray-700`}
        style={{
          height: "calc(100vh - 220px)",
          width: "100%",
          minHeight: 300,
        }}
      >
        <AgGridReact<RaceConfiguration>
          theme={isDarkMode ? themeDarkBlue : themeAlpine}
          rowData={raceConfigurations}
          columnDefs={columnDefs}
          onCellValueChanged={onCellValueChanged}
          quickFilterText={quickFilterText}
        />
      </div>

      {/* Create Race Modal */}
      <Modal
        isOpen={showCreateModal}
        onClose={() => {
          if (!isCreatingRace) {
            setShowCreateModal(false);
            setCreateForm({ name: "", abbreviation: "" });
          }
        }}
        size="md"
      >
        <div className="p-4 space-y-6">
          <div>
            <h3 className="text-lg font-semibold text-gray-900 dark:text-gray-100 mb-2">
              Create New Race
            </h3>
            <p className="text-sm text-gray-600 dark:text-gray-400">
              Create a new race configuration with name and abbreviation:
            </p>
          </div>

          <div className="space-y-4">
            <div>
              <label
                htmlFor="race-name"
                className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
              >
                Name *
              </label>
              <input
                type="text"
                id="race-name"
                value={createForm.name}
                onChange={(e) =>
                  setCreateForm({ ...createForm, name: e.target.value })
                }
                disabled={isCreatingRace}
                className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500 disabled:opacity-50 disabled:cursor-not-allowed"
                placeholder="e.g., Hume, Elvaan, Tarutaru"
              />
            </div>
            
            <div>
              <label
                htmlFor="race-abbreviation"
                className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
              >
                Abbreviation *
              </label>
              <input
                type="text"
                id="race-abbreviation"
                value={createForm.abbreviation}
                onChange={(e) =>
                  setCreateForm({
                    ...createForm,
                    abbreviation: e.target.value.toUpperCase(),
                  })
                }
                disabled={isCreatingRace}
                className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500 disabled:opacity-50 disabled:cursor-not-allowed"
                placeholder="e.g., HUM, ELV, TAR"
                maxLength={3}
              />
              <p className="mt-1 text-xs text-gray-500 dark:text-gray-400">
                Maximum 3 characters, automatically converted to uppercase
              </p>
            </div>
          </div>

          <div className="flex justify-between items-center pt-4 border-t border-gray-200 dark:border-gray-700">
            <div className="text-sm text-gray-600 dark:text-gray-400">
              {createForm.name && createForm.abbreviation
                ? "Ready to create race"
                : "Both name and abbreviation are required"}
            </div>

            <div className="flex space-x-2">
              <button
                onClick={() => {
                  setShowCreateModal(false);
                  setCreateForm({ name: "", abbreviation: "" });
                }}
                disabled={isCreatingRace}
                className="px-4 py-2 text-sm font-medium text-gray-700 bg-gray-100 border border-gray-300 rounded-md hover:bg-gray-200 focus:outline-none focus:ring-2 focus:ring-gray-500 dark:bg-gray-700 dark:text-gray-300 dark:border-gray-600 dark:hover:bg-gray-600 cursor-pointer disabled:opacity-50 disabled:cursor-not-allowed"
              >
                Cancel
              </button>
              <button
                onClick={handleCreateRace}
                disabled={!createForm.name || !createForm.abbreviation || isCreatingRace}
                className="px-4 py-2 text-sm font-medium text-white bg-blue-600 border border-transparent rounded-md hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-500 cursor-pointer disabled:opacity-50 disabled:cursor-not-allowed"
              >
                {isCreatingRace ? (
                  <div className="flex items-center space-x-2">
                    <div className="animate-spin rounded-full h-4 w-4 border-b-2 border-white"></div>
                    <span>Creating...</span>
                  </div>
                ) : (
                  "Create Race"
                )}
              </button>
            </div>
          </div>
        </div>
      </Modal>

      {/* Delete Race Modal */}
      {showDeleteModal && selectedRace && (
        <ConfirmationModal
          isOpen={showDeleteModal}
          title="Delete Race Configuration"
          message={`Are you sure you want to delete the race configuration for "${selectedRace.name}"? This action cannot be undone.`}
          onConfirm={handleDeleteRace}
          onCancel={() => {
            setShowDeleteModal(false);
            setSelectedRace(null);
          }}
        />
      )}

      {/* Edit Stats Modal */}
      {showStatsModal && selectedRace && (
        <Modal isOpen={showStatsModal} onClose={handleCancelStats} size="md">
          <div className="p-4 space-y-6">
            <div>
              <h3 className="text-lg font-semibold text-gray-900 dark:text-gray-100 mb-2">
                Edit Base Stats for {selectedRace.name}
              </h3>
              <p className="text-sm text-gray-600 dark:text-gray-400">
                Set the base stat values for this race configuration:
              </p>
            </div>

            <div className="space-y-4 max-h-96 overflow-y-auto">
              {baseStats.map((stat) => {
                const currentValue = editingStats[stat.id];
                return (
                  <div key={stat.id}>
                    <label className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2">
                      {stat.displayName || stat.name}
                    </label>
                    <input
                      type="number"
                      min="0"
                      max="999"
                      value={currentValue || ""}
                      onChange={(e) => {
                        const value =
                          e.target.value === ""
                            ? null
                            : parseInt(e.target.value);
                        setEditingStats((prev) => ({
                          ...prev,
                          [stat.id]: value,
                        }));
                      }}
                      className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                      placeholder="0"
                    />
                  </div>
                );
              })}
            </div>

            <div className="flex justify-between items-center pt-4 border-t border-gray-200 dark:border-gray-700">
              <div className="text-sm text-gray-600 dark:text-gray-400">
                Leave empty or set to 0 to remove stat
              </div>

              <div className="flex space-x-2">
                <button
                  onClick={handleCancelStats}
                  disabled={isUpdatingStats}
                  className="px-4 py-2 text-sm font-medium text-gray-700 bg-gray-100 border border-gray-300 rounded-md hover:bg-gray-200 focus:outline-none focus:ring-2 focus:ring-gray-500 dark:bg-gray-700 dark:text-gray-300 dark:border-gray-600 dark:hover:bg-gray-600 cursor-pointer disabled:opacity-50 disabled:cursor-not-allowed"
                >
                  Cancel
                </button>
                <button
                  onClick={handleSaveStats}
                  disabled={isUpdatingStats}
                  className="px-4 py-2 text-sm font-medium text-white bg-blue-600 border border-transparent rounded-md hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-500 cursor-pointer disabled:opacity-50 disabled:cursor-not-allowed"
                >
                  {isUpdatingStats ? (
                    <div className="flex items-center space-x-2">
                      <div className="animate-spin rounded-full h-4 w-4 border-b-2 border-white"></div>
                      <span>Updating...</span>
                    </div>
                  ) : (
                    "Save Stats"
                  )}
                </button>
              </div>
            </div>
          </div>
        </Modal>
      )}
    </div>
  );
}
