import { useState, useRef, useEffect } from "react";
import { Link, useLocation } from "react-router-dom";
import logo from "../assets/icon.png";
import { useAuth } from "../contexts/AuthContext";

export function Navbar() {
  const location = useLocation();
  const [menuOpen, setMenuOpen] = useState(false);
  const [adminDropdownOpen, setAdminDropdownOpen] = useState(false);
  const { isAuthenticated, logout } = useAuth();
  const dropdownRef = useRef<HTMLDivElement>(null);

  // Close dropdown when clicking outside
  useEffect(() => {
    function handleClickOutside(event: MouseEvent) {
      if (
        dropdownRef.current &&
        !dropdownRef.current.contains(event.target as Node)
      ) {
        setAdminDropdownOpen(false);
      }
    }

    document.addEventListener("mousedown", handleClickOutside);
    return () => {
      document.removeEventListener("mousedown", handleClickOutside);
    };
  }, []);

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

          {isAuthenticated && (
            <>
              <Link
                to="/profiles"
                className={`px-4 py-2 rounded transition-colors duration-150 ${isActive(
                  "/profiles"
                )} dark:hover:bg-gray-800 dark:hover:text-white dark:text-gray-400`}
                onClick={() => setMenuOpen(false)}
              >
                My Characters
              </Link>

              {/* Admin Dropdown */}
              <div className="relative" ref={dropdownRef}>
                <button
                  onClick={() => setAdminDropdownOpen(!adminDropdownOpen)}
                  className={`px-4 py-2 rounded transition-colors duration-150 flex items-center space-x-1 ${
                    location.pathname === "/stats" ||
                    location.pathname === "/admin/races" ||
                    location.pathname === "/admin/jobs"
                      ? "bg-primary text-primary-foreground"
                      : "hover:bg-muted hover:text-foreground text-muted-foreground"
                  } dark:hover:bg-gray-800 dark:hover:text-white dark:text-gray-400`}
                >
                  <span>Admin</span>
                  <svg
                    className={`w-4 h-4 transition-transform duration-200 ${
                      adminDropdownOpen ? "rotate-180" : ""
                    }`}
                    fill="none"
                    stroke="currentColor"
                    viewBox="0 0 24 24"
                  >
                    <path
                      strokeLinecap="round"
                      strokeLinejoin="round"
                      strokeWidth={2}
                      d="M19 9l-7 7-7-7"
                    />
                  </svg>
                </button>

                {adminDropdownOpen && (
                  <div className="absolute top-full left-0 mt-1 w-48 bg-background border border-border rounded-md shadow-lg z-50 dark:bg-gray-800 dark:border-gray-600">
                    <div className="py-1">
                      <Link
                        to="/stats"
                        className={`block px-4 py-2 text-sm transition-colors duration-150 ${isActive(
                          "/stats"
                        )} dark:hover:bg-gray-700 dark:text-gray-300`}
                        onClick={() => {
                          setAdminDropdownOpen(false);
                          setMenuOpen(false);
                        }}
                      >
                        Item Stats
                      </Link>
                      <Link
                        to="/admin/jobs"
                        className={`block px-4 py-2 text-sm transition-colors duration-150 ${isActive(
                          "/admin/jobs"
                        )} dark:hover:bg-gray-700 dark:text-gray-300`}
                        onClick={() => {
                          setAdminDropdownOpen(false);
                          setMenuOpen(false);
                        }}
                      >
                        Jobs
                      </Link>
                      <Link
                        to="/admin/races"
                        className={`block px-4 py-2 text-sm transition-colors duration-150 ${isActive(
                          "/admin/races"
                        )} dark:hover:bg-gray-700 dark:text-gray-300`}
                        onClick={() => {
                          setAdminDropdownOpen(false);
                          setMenuOpen(false);
                        }}
                      >
                        Races
                      </Link>
                    </div>
                  </div>
                )}
              </div>
            </>
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
