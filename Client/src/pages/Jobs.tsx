import { useState } from "react";
import { AgGridReact } from "ag-grid-react";
import { themeAlpine } from "ag-grid-community";
import { colorSchemeDarkBlue } from "ag-grid-community";
import { JobsService } from "../services";
import ConfirmationModal from "../components/ConfirmationModal";
import { useAppData } from "../contexts/AppDataContext";
import { useAuth } from "../contexts/AuthContext";

import type { CellValueChangedEvent, ColDef, ICellRendererParams } from "ag-grid-community";
import type { Job } from "../models/Job";

const themeDarkBlue = themeAlpine.withPart(colorSchemeDarkBlue);

export function Jobs() {
  const { jobs, loading: loadingAppData, refreshJobs } = useAppData();
  const { isAdmin } = useAuth();
  const [quickFilterText, setQuickFilterText] = useState("");
  const [showDeleteConfirm, setShowDeleteConfirm] = useState(false);
  const [jobToDelete, setJobToDelete] = useState<{
    id: number;
    abbreviation: string;
    fullName: string;
  } | null>(null);
  const [isDeleting, setIsDeleting] = useState(false);
  const isDarkMode = window.matchMedia("(prefers-color-scheme: dark)").matches;

  const updateJob = async (job: Job) => {
    try {
      const updatedJob = await JobsService.updateJob(job);
      return updatedJob;
    } catch (error) {
      console.error("Error updating job:", error);
      throw error;
    }
  };

  const deleteJob = async (jobId: number) => {
    try {
      await JobsService.deleteJob(jobId);
      console.log("Job deleted successfully");
    } catch (error) {
      console.error("Error deleting job:", error);
      throw error;
    }
  };

  const handleDeleteJob = (
    jobId: number,
    abbreviation: string,
    fullName: string
  ) => {
    setJobToDelete({ id: jobId, abbreviation, fullName });
    setShowDeleteConfirm(true);
  };

  const confirmDeleteJob = async () => {
    if (!jobToDelete) return;

    setIsDeleting(true);
    try {
      await deleteJob(jobToDelete.id);
      await refreshJobs(); // Refresh the jobs list after successful deletion
      setShowDeleteConfirm(false);
      setJobToDelete(null);
    } catch {
      alert("Failed to delete job. Please try again.");
    } finally {
      setIsDeleting(false);
    }
  };

  const cancelDeleteJob = () => {
    if (isDeleting) return; // Don't allow canceling while deleting
    setShowDeleteConfirm(false);
    setJobToDelete(null);
  };

  const onCellValueChanged = async (event: CellValueChangedEvent<Job>) => {
    const updatedJob = event.data;
    try {
      await updateJob(updatedJob);
      console.log("Job updated successfully");

      // Flash the cell green to indicate successful save
      event.api.flashCells({
        rowNodes: [event.node],
        columns: [event.column.getColId()],
      });
    } catch {
      // Revert the change if the update failed
      event.node.setData(event.oldValue);
      alert("Failed to update job. Please try again.");
    }
  };

  const columnDefs: ColDef<Job>[] = [
    {
      headerName: "Id",
      field: "id",
      sortable: true,
      filter: true,
      width: 100,
      editable: false,
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
      headerName: "Full Name",
      field: "fullName",
      sortable: true,
      filter: true,
      width: 250,
      editable: isAdmin,
      enableCellChangeFlash: true,
    },
    {
      headerName: "Dual Wield",
      field: "canDualWield",
      sortable: true,
      filter: true,
      width: 150,
      editable: isAdmin,
      enableCellChangeFlash: true,
      cellRenderer: (params: ICellRendererParams<Job>) => {
        const canDualWield = params.value;
        return (
          <div className="flex justify-center items-center h-full">
            <span
              className={`inline-flex items-center px-2.5 py-0.5 rounded-full text-xs font-medium ${
                canDualWield
                  ? "bg-green-100 text-green-800 dark:bg-green-900/20 dark:text-green-400"
                  : "bg-gray-100 text-gray-800 dark:bg-gray-900/20 dark:text-gray-400"
              }`}
            >
              {canDualWield ? "Yes" : "No"}
            </span>
          </div>
        );
      },
      cellEditor: "agSelectCellEditor",
      cellEditorParams: {
        values: [true, false],
        valueListMaxHeight: 100,
        formatValue: (value: boolean) => (value ? "Yes" : "No"),
      },
    },
    {
      headerName: "Actions",
      width: 120,
      sortable: false,
      filter: false,
      editable: false,
      cellRenderer: (params: { data: Job }) => {
        const job = params.data;

        return (
          <div className="flex justify-center items-center h-full space-x-2">
            {/* Delete Button - Only show if admin */}
            {isAdmin && (
              <button
                onClick={() =>
                  handleDeleteJob(job.id, job.abbreviation, job.fullName)
                }
                className="p-2 text-red-400 hover:text-red-600 hover:bg-red-50 dark:hover:bg-red-900/20 rounded transition-colors duration-200"
                title={`Delete ${job.abbreviation} (${job.fullName})`}
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

  if (loadingAppData) {
    return (
      <div className="flex items-center justify-center min-h-screen">
        <div className="text-gray-600 dark:text-gray-400">Loading...</div>
      </div>
    );
  }

  return (
    <div className="space-y-4">
      {/* Header */}
      <div className="flex justify-between items-center">
        <h1 className="text-2xl font-bold text-gray-900 dark:text-white">
          Jobs
        </h1>
        {/* TODO: Add New Job button when AddJobModal is implemented */}
      </div>

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
              placeholder="Filter jobs by abbreviation or full name..."
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

      {/* TODO: Add Job Modal - Only for Admin users */}
      {/* {isAdmin && (
        <AddJobModal
          isOpen={showAddForm}
          onClose={() => setShowAddForm(false)}
          onJobCreated={handleJobCreated}
        />
      )} */}

      {/* Delete Confirmation Modal - Only for Admin users */}
      {isAdmin && (
        <ConfirmationModal
          isOpen={showDeleteConfirm}
          title="Delete Job"
          message={`Are you sure you want to delete the job "${jobToDelete?.abbreviation}" (${jobToDelete?.fullName})? This action cannot be undone and may fail if the job is referenced by other data.`}
          confirmText="Delete"
          cancelText="Cancel"
          isLoading={isDeleting}
          onConfirm={confirmDeleteJob}
          onCancel={cancelDeleteJob}
        />
      )}

      {/* AG Grid */}
      <div
        className={`ag-theme-alpine dark:ag-theme-alpine-dark rounded-xl shadow-md border border-gray-200 dark:border-gray-700`}
        style={{
          height: "calc(100vh - 220px)",
          width: "100%",
          minHeight: 300,
        }}
      >
        <AgGridReact<Job>
          theme={isDarkMode ? themeDarkBlue : themeAlpine}
          rowData={jobs}
          columnDefs={columnDefs}
          onCellValueChanged={onCellValueChanged}
          quickFilterText={quickFilterText}
        />
      </div>
    </div>
  );
}
