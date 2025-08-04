import { useEffect, useState } from "react";
import { AgGridReact } from "ag-grid-react";
import { themeAlpine } from "ag-grid-community";
import { colorSchemeDarkBlue } from "ag-grid-community";

import type { ColDef } from "ag-grid-community";

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

  const columnDefs: ColDef[] = [
    { headerName: "Id", field: "id", sortable: true, filter: true },
    { headerName: "Name", field: "name", sortable: true, filter: true },
    {
      headerName: "Display Name",
      field: "displayName",
      sortable: true,
      filter: true,
    },
    {
      headerName: "Category",
      field: "category",
      sortable: true,
      filter: true,
      rowGroup: false,
    },
    {
      headerName: "Description",
      field: "description",
      sortable: true,
      filter: true,
      rowGroup: false,
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
      style={{ height: 600, width: "100%" }}
    >
      <AgGridReact
        theme={isDarkMode ? themeDarkBlue : themeAlpine}
        rowData={rowData}
        columnDefs={columnDefs}
        // pagination={true}
        // paginationPageSize={20}
        // groupDisplayType="groupRows"
      />
    </div>
  );
}
