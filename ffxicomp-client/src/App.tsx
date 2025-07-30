import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import { GearBrowser } from "./components/GearBrowser";
import ComparePage from "./pages/Compare";
import { Navbar } from "./components/Navbar";

function App() {
  return (
    <div className="font-inter">
      <Router>
        <Navbar />
        <main className="p-4 max-w-8xl mx-auto">
          <Routes>
            <Route path="/" element={<ComparePage />} />
            <Route path="/browse" element={<GearBrowser />} />
          </Routes>
        </main>
      </Router>
    </div>
  );
}

export default App;
