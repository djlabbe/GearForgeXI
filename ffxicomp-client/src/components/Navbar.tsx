import { Link, useLocation } from "react-router-dom";
import logo from "../assets/icon.png";

export function Navbar() {
  const location = useLocation();

  const isActive = (path: string) =>
    location.pathname === path
      ? "bg-primary text-primary-foreground"
      : "hover:bg-muted hover:text-foreground text-muted-foreground";

  return (
    <header className="bg-background text-foreground shadow mb-6 border-b border-border dark:bg-gray-900 dark:text-gray-100 dark:border-gray-700">
      <div className="mx-auto px-4 py-4 flex items-center justify-between">
        <div className="flex items-center space-x-3">
          <img src={logo} alt="FFXI Compare Logo" className="h-8 w-8" />
          <h1 className="text-2xl">FFXI Compare</h1>
        </div>
        <nav className="space-x-2">
          <Link
            to="/"
            className={`px-4 py-2 rounded transition-colors duration-150 ${isActive("/")} dark:hover:bg-gray-800 dark:hover:text-white dark:text-gray-400`}
          >
            Compare Sets
          </Link>
          <Link
            to="/browse"
            className={`px-4 py-2 rounded transition-colors duration-150 ${isActive("/browse")} dark:hover:bg-gray-800 dark:hover:text-white dark:text-gray-400`}
          >
            Browse Gear
          </Link>
        </nav>
      </div>
    </header>
  );
}
