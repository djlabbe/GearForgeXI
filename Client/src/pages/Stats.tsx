import { useEffect, useState } from "react";
import { AgGridReact } from "ag-grid-react";
import { themeAlpine } from "ag-grid-community";
import { colorSchemeDarkBlue } from "ag-grid-community";

import type { CellValueChangedEvent, ColDef } from "ag-grid-community";

const themeDarkBlue = themeAlpine.withPart(colorSchemeDarkBlue);

type Stat = {
  id: number;
  name: string;
  displayName: string;
  category: string;
  description: string;
};

export function Stats() {
  const [rowData, setRowData] = useState<Stat[]>([]);
  const isDarkMode = window.matchMedia("(prefers-color-scheme: dark)").matches;

  const updateStat = async (stat: Stat) => {
    try {
      const response = await fetch(`/api/stats/${stat.id}`, {
        method: "PUT",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(stat),
      });

      if (!response.ok) {
        throw new Error(`Failed to update stat: ${response.statusText}`);
      }

      const updatedStat = await response.json();
      return updatedStat;
    } catch (error) {
      console.error("Error updating stat:", error);
      throw error;
    }
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
  ];

  useEffect(() => {
    fetch("/api/stats")
      .then((res) => res.json())
      .then(setRowData);
  }, []);

  return (
    <div
      className={`ag-theme-alpine dark:ag-theme-alpine-dark rounded-xl shadow-md border border-gray-200 dark:border-gray-700`}
      style={{
        height: "calc(100vh - 130px)",
        width: "100%",
        minHeight: 300,
      }}
    >
      <AgGridReact<Stat>
        theme={isDarkMode ? themeDarkBlue : themeAlpine}
        rowData={rowData}
        columnDefs={columnDefs}
        onCellValueChanged={onCellValueChanged}
        // pagination={true}
        // paginationPageSize={20}
        // groupDisplayType="groupRows"
      />
    </div>
  );
}
