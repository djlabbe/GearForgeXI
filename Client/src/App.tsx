import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import { GearBrowser } from "./pages/GearBrowser";
import ComparePage from "./pages/Compare";
import { Navbar } from "./components/Navbar";
import { Stats } from "./pages/Stats";
import Login from "./pages/Login";
import Register from "./pages/Register";
import { AllCommunityModule, ModuleRegistry } from "ag-grid-community";
import { AppDataProvider } from "./contexts/AppDataContext";
import { AuthProvider, useAuth } from "./contexts/AuthContext";
import { AuthLoadingScreen } from "./components/LoadingSpinner";

// Register all Community features
ModuleRegistry.registerModules([AllCommunityModule]);

// Inner component that can use the AuthContext
function AppContent() {
  const { isLoading } = useAuth();

  if (isLoading) {
    return <AuthLoadingScreen message="Authenticating..." />;
  }

  return (
    <AppDataProvider>
      <Router>
        <Navbar />
        <main className="p-4 max-w-8xl mx-auto">
          <Routes>
            <Route path="/" element={<ComparePage />} />
            <Route path="/gear" element={<GearBrowser />} />
            <Route path="/stats" element={<Stats />} />
            <Route path="/login" element={<Login />} />
            <Route path="/register" element={<Register />} />
          </Routes>
        </main>
      </Router>
    </AppDataProvider>
  );
}

function App() {
  return (
    <div className="font-inter bg-white text-gray-900 dark:bg-gray-900 dark:text-gray-100 min-h-screen transition-colors">
      <AuthProvider>
        <AppContent />
      </AuthProvider>
    </div>
  );
}export default App;
