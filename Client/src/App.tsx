import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import { GearBrowser } from "./pages/GearBrowser";
import ComparePage from "./pages/Compare";
import { Navbar } from "./components/Navbar";
import { JobsProvider } from "./contexts/JobsContext";
import { Stats } from "./pages/Stats";

import { AllCommunityModule, ModuleRegistry } from "ag-grid-community";
// Register all Community features
ModuleRegistry.registerModules([AllCommunityModule]);

function App() {
  return (
    <div className="font-inter bg-white text-gray-900 dark:bg-gray-900 dark:text-gray-100 min-h-screen transition-colors">
      <JobsProvider>
        <Router>
          <Navbar />
          <main className="p-4 max-w-8xl mx-auto">
            <Routes>
              <Route path="/" element={<ComparePage />} />
              <Route path="/browse" element={<GearBrowser />} />
              <Route path="/stats" element={<Stats />} />
            </Routes>
          </main>
        </Router>
      </JobsProvider>
    </div>
  );
}

export default App;
