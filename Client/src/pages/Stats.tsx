import { useState } from "react";
import { AgGridReact } from "ag-grid-react";
import { themeAlpine } from "ag-grid-community";
import { colorSchemeDarkBlue } from "ag-grid-community";
import ApiService from "../utils/apiService";
import AddStatModal from "../components/AddStatModal";
import { useAppData } from "../contexts/AppDataContext";

import type { CellValueChangedEvent, ColDef } from "ag-grid-community";
import type { Stat } from "../models/Stat";

const themeDarkBlue = themeAlpine.withPart(colorSchemeDarkBlue);

export function Stats() {
  const { stats, loading: loadingAppData } = useAppData();
  const [showAddForm, setShowAddForm] = useState(false);
  const [quickFilterText, setQuickFilterText] = useState("");
  const isDarkMode = window.matchMedia("(prefers-color-scheme: dark)").matches;

  const updateStat = async (stat: Stat) => {
    try {
      const updatedStat = await ApiService.updateStat(stat);
      return updatedStat;
    } catch (error) {
      console.error("Error updating stat:", error);
      throw error;
    }
  };

  const handleStatCreated = () => {
    // The AddStatModal will handle refreshing the AppDataContext
    setShowAddForm(false);
  };

  const onCellValueChanged = async (event: CellValueChangedEvent<Stat>) => {
    const updatedStat = event.data;
    try {
      await updateStat(updatedStat);
      console.log("Stat updated successfully");
      
      // Flash the cell green to indicate successful save
      event.api.flashCells({
        rowNodes: [event.node],
        columns: [event.column.getColId()]
      });
    } catch (error) {
      // Revert the change if the update failed
      event.node.setData(event.oldValue);
      alert("Failed to update stat. Please try again.");
    }
  };

  const columnDefs: ColDef[] = [
    {
      headerName: "Id",
      field: "id",
      sortable: true,
      filter: true,
      width: 100,
      editable: false,
    },
    {
      headerName: "Name",
      field: "name",
      sortable: true,
      filter: true,
      editable: true,
      enableCellChangeFlash: true,
    },
    {
      headerName: "Display Name",
      field: "displayName",
      sortable: true,
      filter: true,
      width: 300,
      editable: true,
      enableCellChangeFlash: true,
    },
    {
      headerName: "Description",
      field: "description",
      sortable: true,
      filter: true,
      rowGroup: false,
      width: 500,
      editable: true,
      enableCellChangeFlash: true,
    },
    {
      headerName: "Category",
      field: "category",
      sortable: true,
      filter: true,
      rowGroup: false,
      editable: true,
      enableCellChangeFlash: true,
    },
    {
      headerName: "Gear Count",
      field: "gearItemCount",
      sortable: true,
      filter: true,
      width: 150,
      editable: false,
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
      {/* Header with Add New Stat Button */}
      <div className="flex justify-between items-center">
        <h1 className="text-2xl font-bold text-gray-900 dark:text-white">Stats Admin</h1>
        <button
          onClick={() => setShowAddForm(true)}
          className="px-4 py-2 bg-blue-600 hover:bg-blue-700 text-white rounded-lg transition-colors duration-200 font-medium"
        >
          Add New Stat
        </button>
      </div>

      {/* Quick Filter */}
      <div className="flex items-center space-x-4">
        <div className="flex-1">
          <div className="relative">
            <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
              <svg className="h-4 w-4 text-gray-400" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z" />
              </svg>
            </div>
            <input
              type="text"
              id="quick-filter"
              value={quickFilterText}
              onChange={(e) => setQuickFilterText(e.target.value)}
              placeholder="Filter stats by name, display name, category, or description..."
              className="w-full pl-10 p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
              autoComplete="off"
            />
            {quickFilterText && (
              <button
                type="button"
                onClick={() => setQuickFilterText("")}
                className="absolute inset-y-0 right-0 pr-3 flex items-center text-gray-400 hover:text-gray-600 dark:hover:text-gray-300"
              >
                <svg className="h-4 w-4" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                  <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M6 18L18 6M6 6l12 12" />
                </svg>
              </button>
            )}
          </div>
        </div>
      </div>

      {/* Add Stat Modal */}
      <AddStatModal 
        isOpen={showAddForm} 
        onClose={() => setShowAddForm(false)} 
        onStatCreated={handleStatCreated}
      />

      {/* AG Grid */}
      <div
        className={`ag-theme-alpine dark:ag-theme-alpine-dark rounded-xl shadow-md border border-gray-200 dark:border-gray-700`}
        style={{
          height: "calc(100vh - 200px)",
          width: "100%",
          minHeight: 300,
        }}
      >
        <AgGridReact<Stat>
          theme={isDarkMode ? themeDarkBlue : themeAlpine}
          rowData={stats}
          columnDefs={columnDefs}
          onCellValueChanged={onCellValueChanged}
          quickFilterText={quickFilterText}
        />
      </div>
    </div>
  );
}
