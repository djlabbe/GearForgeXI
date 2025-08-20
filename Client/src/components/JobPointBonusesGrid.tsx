import { useState } from "react";
import { AgGridReact } from "ag-grid-react";
import { themeAlpine } from "ag-grid-community";
import { colorSchemeDarkBlue } from "ag-grid-community";
import { JobConfigurationsService } from "../services";
import AddJobPointBonusModal from "./AddJobPointBonusModal";
import ConfirmationModal from "./ConfirmationModal";

import type {
  CellValueChangedEvent,
  ColDef,
  ICellRendererParams,
} from "ag-grid-community";
import type { JobPointBonus } from "../models/JobConfiguration";

const themeDarkBlue = themeAlpine.withPart(colorSchemeDarkBlue);

interface JobPointBonusesGridProps {
  jobPointBonuses: JobPointBonus[];
  onJobPointBonusesChange: (newJobPointBonuses: JobPointBonus[]) => void;
  jobConfigurationId: number;
  isAdmin: boolean;
  isDarkMode: boolean;
  height?: number;
}

export function JobPointBonusesGrid({
  jobPointBonuses,
  onJobPointBonusesChange,
  jobConfigurationId,
  isAdmin,
  isDarkMode,
  height = 400,
}: JobPointBonusesGridProps) {
  const [isAddJobPointBonusModalOpen, setIsAddJobPointBonusModalOpen] = useState(false);
  const [showDeleteConfirm, setShowDeleteConfirm] = useState(false);
  const [jobPointBonusToDelete, setJobPointBonusToDelete] = useState<{
    id: number;
    statName: string;
  } | null>(null);
  const [isDeleting, setIsDeleting] = useState(false);

  // Column definitions for Job Point Bonuses
  const jpBonusesColumnDefs: ColDef<JobPointBonus>[] = [
    {
      headerName: "ID",
      field: "id",
      width: 80,
      editable: false,
    },
    {
      headerName: "Stat",
      field: "stat.displayName",
      width: 300,
      editable: false,
      valueGetter: (params) =>
        params.data?.stat?.displayName || params.data?.stat?.name,
    },
    {
      headerName: "Value",
      field: "value",
      width: 100,
      editable: isAdmin,
      enableCellChangeFlash: true,
      cellEditor: "agNumberCellEditor",
      cellEditorParams: {
        min: -999,
        max: 999,
        precision: 0,
      },
      valueSetter: (params) => {
        const newValue = parseInt(params.newValue);
        if (isNaN(newValue) || newValue < -999 || newValue > 999) {
          return false; // Reject invalid values
        }
        params.data.value = newValue;
        return true;
      },
    },
    {
      headerName: "Actions",
      width: 120,
      sortable: false,
      filter: false,
      editable: false,
      cellRenderer: (params: ICellRendererParams<JobPointBonus>) => {
        const jobPointBonus = params.data;
        if (!jobPointBonus) return null;

        return (
          <div className="flex justify-center items-center h-full space-x-2">
            {/* Delete Button - Only show if admin */}
            {isAdmin && (
              <button
                onClick={() => handleDeleteJobPointBonus(jobPointBonus.id, jobPointBonus.stat?.displayName || jobPointBonus.stat?.name || 'Unknown')}
                className="p-2 text-red-400 hover:text-red-600 hover:bg-red-50 dark:hover:bg-red-900/20 rounded transition-colors duration-200"
                title={`Delete ${jobPointBonus.stat?.displayName || jobPointBonus.stat?.name || 'Unknown'} bonus`}
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
            )}
          </div>
        );
      },
    },
  ];

  const handleAddJobPointBonus = () => {
    setIsAddJobPointBonusModalOpen(true);
  };

  const handleJobPointBonusCreated = (newJobPointBonus: JobPointBonus) => {
    const updatedJobPointBonuses = [...jobPointBonuses, newJobPointBonus];
    onJobPointBonusesChange(updatedJobPointBonuses);
  };

  const handleJobPointBonusCellValueChanged = async (
    event: CellValueChangedEvent<JobPointBonus>
  ) => {
    const updatedJobPointBonus = event.data;
    try {
      await JobConfigurationsService.updateJobPointBonus(
        jobConfigurationId,
        updatedJobPointBonus.statId,
        updatedJobPointBonus.value
      );
      console.log("Job point bonus updated successfully");

      // Flash the cell green to indicate successful save
      event.api.flashCells({
        rowNodes: [event.node],
        columns: [event.column.getColId()],
      });
    } catch {
      // Revert the change if the update failed
      event.node.setData(event.oldValue);
      alert("Failed to update job point bonus. Please try again.");
    }
  };

  const handleDeleteJobPointBonus = (id: number, statName: string) => {
    setJobPointBonusToDelete({ id, statName });
    setShowDeleteConfirm(true);
  };

  const confirmDeleteJobPointBonus = async () => {
    if (!jobPointBonusToDelete) return;

    setIsDeleting(true);
    try {
      // Find the job point bonus to get its statId
      const jobPointBonusData = jobPointBonuses.find(jpb => jpb.id === jobPointBonusToDelete.id);
      if (!jobPointBonusData) {
        throw new Error("Job point bonus not found");
      }

      await JobConfigurationsService.deleteJobPointBonus(
        jobConfigurationId,
        jobPointBonusData.statId
      );

      // Update the local state by removing the deleted job point bonus
      const updatedJobPointBonuses = jobPointBonuses.filter(
        (jpb) => jpb.id !== jobPointBonusToDelete.id
      );
      onJobPointBonusesChange(updatedJobPointBonuses);

      setShowDeleteConfirm(false);
      setJobPointBonusToDelete(null);
      console.log("Job point bonus deleted successfully");
    } catch (error) {
      console.error("Error deleting job point bonus:", error);
      alert("Failed to delete job point bonus. Please try again.");
    } finally {
      setIsDeleting(false);
    }
  };

  const cancelDeleteJobPointBonus = () => {
    if (isDeleting) return; // Don't allow canceling while deleting
    setShowDeleteConfirm(false);
    setJobPointBonusToDelete(null);
  };

  return (
    <>
      <div className="space-y-2">
        <div className="flex justify-between items-center">
          <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
            Job Point Bonuses ({jobPointBonuses.length})
          </h3>
          {isAdmin && (
            <button
              onClick={handleAddJobPointBonus}
              className="px-3 py-1 text-sm bg-blue-600 hover:bg-blue-700 text-white rounded-md transition-colors duration-200 font-medium cursor-pointer"
            >
              Add Job Point Bonus
            </button>
          )}
        </div>
        <div
          className="ag-theme-alpine dark:ag-theme-alpine-dark rounded-xl shadow-md border border-gray-200 dark:border-gray-700"
          style={{ height, width: "100%" }}
        >
          <AgGridReact<JobPointBonus>
            theme={isDarkMode ? themeDarkBlue : themeAlpine}
            rowData={jobPointBonuses}
            columnDefs={jpBonusesColumnDefs}
            onCellValueChanged={handleJobPointBonusCellValueChanged}
            defaultColDef={{
              resizable: true,
              sortable: true,
              filter: true,
            }}
          />
        </div>
      </div>

      {/* Add Job Point Bonus Modal */}
      <AddJobPointBonusModal
        isOpen={isAddJobPointBonusModalOpen}
        onClose={() => setIsAddJobPointBonusModalOpen(false)}
        onJobPointBonusCreated={handleJobPointBonusCreated}
        jobConfigurationId={jobConfigurationId}
      />

      {/* Confirmation Modal for Deletion */}
      {showDeleteConfirm && jobPointBonusToDelete && (
        <ConfirmationModal
          isOpen={showDeleteConfirm}
          onConfirm={confirmDeleteJobPointBonus}
          onCancel={cancelDeleteJobPointBonus}
          title="Delete Job Point Bonus"
          message={`Are you sure you want to delete the job point bonus for "${jobPointBonusToDelete.statName}"? This action cannot be undone.`}
          confirmText="Delete"
          cancelText="Cancel"
          isLoading={isDeleting}
        />
      )}
    </>
  );
}

export default JobPointBonusesGrid;
