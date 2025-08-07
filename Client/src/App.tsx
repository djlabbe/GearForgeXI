import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import { GearBrowser } from "./pages/GearBrowser";
import ComparePage from "./pages/Compare";
import { Navbar } from "./components/Navbar";
import { Stats } from "./pages/Stats";
import Login from "./pages/Login";
import { AllCommunityModule, ModuleRegistry } from "ag-grid-community";
import { AppDataProvider } from "./contexts/AppDataContext";
import { AuthProvider } from "./contexts/AuthContext";

// Register all Community features
ModuleRegistry.registerModules([AllCommunityModule]);

function App() {
  return (
    <div className="font-inter bg-white text-gray-900 dark:bg-gray-900 dark:text-gray-100 min-h-screen transition-colors">
      <AuthProvider>
        <AppDataProvider>
              <Router>
                <Navbar />
                <main className="p-4 max-w-8xl mx-auto">
                  <Routes>
                    <Route path="/" element={<ComparePage />} />
                    <Route path="/gear" element={<GearBrowser />} />
                    <Route path="/stats" element={<Stats />} />
                    <Route path="/login" element={<Login />} />
                  </Routes>
                </main>
              </Router>
        </AppDataProvider>
      </AuthProvider>
    </div>
  );
}export default App;
