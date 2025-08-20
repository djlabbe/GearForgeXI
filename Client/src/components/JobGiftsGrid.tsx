import { useState } from "react";
import { AgGridReact } from "ag-grid-react";
import { themeAlpine } from "ag-grid-community";
import { colorSchemeDarkBlue } from "ag-grid-community";
import { JobConfigurationsService } from "../services";
import AddJobGiftModal from "./AddJobGiftModal";
import ConfirmationModal from "./ConfirmationModal";

import type {
  CellValueChangedEvent,
  ColDef,
  ICellRendererParams,
} from "ag-grid-community";
import type { JobGift } from "../models/JobConfiguration";

const themeDarkBlue = themeAlpine.withPart(colorSchemeDarkBlue);

interface JobGiftsGridProps {
  jobGifts: JobGift[];
  onJobGiftsChange: (newJobGifts: JobGift[]) => void;
  jobConfigurationId: number;
  isAdmin: boolean;
  isDarkMode: boolean;
  height?: number;
}

export function JobGiftsGrid({
  jobGifts,
  onJobGiftsChange,
  jobConfigurationId,
  isAdmin,
  isDarkMode,
  height = 400,
}: JobGiftsGridProps) {
  const [isAddJobGiftModalOpen, setIsAddJobGiftModalOpen] = useState(false);
  const [showDeleteConfirm, setShowDeleteConfirm] = useState(false);
  const [jobGiftToDelete, setJobGiftToDelete] = useState<{
    id: number;
    statName: string;
  } | null>(null);
  const [isDeleting, setIsDeleting] = useState(false);

  // Column definitions for Job Gifts
  const jobGiftsColumnDefs: ColDef<JobGift>[] = [
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
      cellRenderer: (params: ICellRendererParams<JobGift>) => {
        const jobGift = params.data;
        if (!jobGift) return null;

        return (
          <div className="flex justify-center items-center h-full space-x-2">
            {/* Delete Button - Only show if admin */}
            {isAdmin && (
              <button
                onClick={() => handleDeleteJobGift(jobGift.id, jobGift.stat?.displayName || jobGift.stat?.name || 'Unknown')}
                className="p-2 text-red-400 hover:text-red-600 hover:bg-red-50 dark:hover:bg-red-900/20 rounded transition-colors duration-200"
                title={`Delete ${jobGift.stat?.displayName || jobGift.stat?.name || 'Unknown'} gift`}
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

  const handleAddJobGift = () => {
    setIsAddJobGiftModalOpen(true);
  };

  const handleJobGiftCreated = (newJobGift: JobGift) => {
    const updatedJobGifts = [...jobGifts, newJobGift];
    onJobGiftsChange(updatedJobGifts);
  };

  const handleJobGiftCellValueChanged = async (
    event: CellValueChangedEvent<JobGift>
  ) => {
    const updatedJobGift = event.data;
    try {
      await JobConfigurationsService.updateJobGift(
        jobConfigurationId,
        updatedJobGift.statId,
        updatedJobGift.value
      );
      console.log("Job gift updated successfully");

      // Flash the cell green to indicate successful save
      event.api.flashCells({
        rowNodes: [event.node],
        columns: [event.column.getColId()],
      });
    } catch {
      // Revert the change if the update failed
      event.node.setData(event.oldValue);
      alert("Failed to update job gift. Please try again.");
    }
  };

  const handleDeleteJobGift = (id: number, statName: string) => {
    setJobGiftToDelete({ id, statName });
    setShowDeleteConfirm(true);
  };

  const confirmDeleteJobGift = async () => {
    if (!jobGiftToDelete) return;

    setIsDeleting(true);
    try {
      // Find the job gift to get its statId
      const jobGiftData = jobGifts.find(jg => jg.id === jobGiftToDelete.id);
      if (!jobGiftData) {
        throw new Error("Job gift not found");
      }

      await JobConfigurationsService.deleteJobGift(
        jobConfigurationId,
        jobGiftData.statId
      );

      // Update the local state by removing the deleted job gift
      const updatedJobGifts = jobGifts.filter(
        (jg) => jg.id !== jobGiftToDelete.id
      );
      onJobGiftsChange(updatedJobGifts);

      setShowDeleteConfirm(false);
      setJobGiftToDelete(null);
      console.log("Job gift deleted successfully");
    } catch (error) {
      console.error("Error deleting job gift:", error);
      alert("Failed to delete job gift. Please try again.");
    } finally {
      setIsDeleting(false);
    }
  };

  const cancelDeleteJobGift = () => {
    if (isDeleting) return; // Don't allow canceling while deleting
    setShowDeleteConfirm(false);
    setJobGiftToDelete(null);
  };

  return (
    <>
      <div className="space-y-2">
        <div className="flex justify-between items-center">
          <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
            Job Gifts ({jobGifts.length})
          </h3>
          {isAdmin && (
            <button
              onClick={handleAddJobGift}
              className="px-3 py-1 text-sm bg-blue-600 hover:bg-blue-700 text-white rounded-md transition-colors duration-200 font-medium cursor-pointer"
            >
              Add Job Gift
            </button>
          )}
        </div>
        <div
          className="ag-theme-alpine dark:ag-theme-alpine-dark rounded-xl shadow-md border border-gray-200 dark:border-gray-700"
          style={{ height, width: "100%" }}
        >
          <AgGridReact<JobGift>
            theme={isDarkMode ? themeDarkBlue : themeAlpine}
            rowData={jobGifts}
            columnDefs={jobGiftsColumnDefs}
            onCellValueChanged={handleJobGiftCellValueChanged}
            defaultColDef={{
              resizable: true,
              sortable: true,
              filter: true,
            }}
          />
        </div>
      </div>

      {/* Add Job Gift Modal */}
      <AddJobGiftModal
        isOpen={isAddJobGiftModalOpen}
        onClose={() => setIsAddJobGiftModalOpen(false)}
        onJobGiftCreated={handleJobGiftCreated}
        jobConfigurationId={jobConfigurationId}
      />

      {/* Confirmation Modal for Deletion */}
      {showDeleteConfirm && jobGiftToDelete && (
        <ConfirmationModal
          isOpen={showDeleteConfirm}
          onConfirm={confirmDeleteJobGift}
          onCancel={cancelDeleteJobGift}
          title="Delete Job Gift"
          message={`Are you sure you want to delete the job gift for "${jobGiftToDelete.statName}"? This action cannot be undone.`}
          confirmText="Delete"
          cancelText="Cancel"
          isLoading={isDeleting}
        />
      )}
    </>
  );
}

export default JobGiftsGrid;
