import { useState } from "react";
import { Link, useLocation } from "react-router-dom";
import logo from "../assets/icon.png";
import { useAuth } from "../contexts/AuthContext";

export function Navbar() {
  const location = useLocation();
  const [menuOpen, setMenuOpen] = useState(false);
  const { isAuthenticated, logout } = useAuth();

  const isActive = (path: string) =>
    location.pathname === path
      ? "bg-primary text-primary-foreground"
      : "hover:bg-muted hover:text-foreground text-muted-foreground";

  const handleLogout = () => {
    logout();
    setMenuOpen(false);
  };

  return (
    <header className="bg-background text-foreground shadow mb-6 border-b border-border dark:bg-gray-900 dark:text-gray-100 dark:border-gray-700">
      <div className="mx-auto px-4 py-4 flex flex-col sm:flex-row items-start sm:items-center justify-between gap-4">
        <div className="flex items-center space-x-3 w-full sm:w-auto">
          <img src={logo} alt="GearForge XI Logo" className="h-8 w-8" />
          <h1 className="text-2xl">GearForge XI</h1>
          {/* Hamburger button for mobile */}
          <button
            className="sm:hidden ml-auto p-2 rounded hover:bg-muted focus:outline-none"
            aria-label="Toggle menu"
            onClick={() => setMenuOpen((open) => !open)}
          >
            <svg
              className="w-6 h-6"
              fill="none"
              stroke="currentColor"
              viewBox="0 0 24 24"
            >
              {menuOpen ? (
                <path
                  strokeLinecap="round"
                  strokeLinejoin="round"
                  strokeWidth={2}
                  d="M6 18L18 6M6 6l12 12"
                />
              ) : (
                <path
                  strokeLinecap="round"
                  strokeLinejoin="round"
                  strokeWidth={2}
                  d="M4 6h16M4 12h16M4 18h16"
                />
              )}
            </svg>
          </button>
        </div>
        {/* Collapsible nav */}
        <nav
          className={`flex-col gap-2 w-full sm:w-auto sm:flex-row sm:flex ${
            menuOpen ? "flex" : "hidden"
          } sm:items-center`}
        >
          <Link
            to="/"
            className={`px-4 py-2 rounded transition-colors duration-150 ${isActive(
              "/"
            )} dark:hover:bg-gray-800 dark:hover:text-white dark:text-gray-400`}
            onClick={() => setMenuOpen(false)}
          >
            Build / Compare Sets
          </Link>
          <Link
            to="/gear"
            className={`px-4 py-2 rounded transition-colors duration-150 ${isActive(
              "/gear"
            )} dark:hover:bg-gray-800 dark:hover:text-white dark:text-gray-400`}
            onClick={() => setMenuOpen(false)}
          >
            Browse Equipment
          </Link>
          <Link
            to="/stats"
            className={`px-4 py-2 rounded transition-colors duration-150 ${isActive(
              "/stats"
            )} dark:hover:bg-gray-800 dark:hover:text-white dark:text-gray-400`}
            onClick={() => setMenuOpen(false)}
          >
            Item Stats
          </Link>

          {isAuthenticated && (
            <Link
              to="/profiles"
              className={`px-4 py-2 rounded transition-colors duration-150 ${isActive(
                "/profiles"
              )} dark:hover:bg-gray-800 dark:hover:text-white dark:text-gray-400`}
              onClick={() => setMenuOpen(false)}
            >
              My Characters
            </Link>
          )}

          {isAuthenticated ? (
            <div className="flex items-center space-x-2">
              <button
                onClick={handleLogout}
                className="px-4 py-2 rounded transition-colors duration-150 hover:bg-muted hover:text-foreground text-muted-foreground dark:hover:bg-gray-800 dark:hover:text-white dark:text-gray-400 cursor-pointer"
              >
                Logout
              </button>
            </div>
          ) : (
            <Link
              to="/login"
              className={`px-4 py-2 rounded transition-colors duration-150 ${isActive(
                "/login"
              )} dark:hover:bg-gray-800 dark:hover:text-white dark:text-gray-400`}
              onClick={() => setMenuOpen(false)}
            >
              Login
            </Link>
          )}
        </nav>
      </div>
    </header>
  );
}
