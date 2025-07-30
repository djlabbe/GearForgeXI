import { Link, useLocation } from "react-router-dom";

export function Navbar() {
  const location = useLocation();

  const isActive = (path: string) =>
    location.pathname === path
      ? "bg-primary text-primary-foreground"
      : "hover:bg-muted hover:text-foreground text-muted-foreground";

  return (
    <header className="bg-background text-foreground shadow mb-6 border-b border-border">
      <div className="mx-auto px-4 py-4 flex items-center justify-between">
        <h1 className="text-2xl font-bold">FFXI Compare</h1>
        <nav className="space-x-2">
          <Link
            to="/"
            className={`px-4 py-2 rounded transition-colors duration-150 ${isActive("/")}`}
          >
            Compare Sets
          </Link>
          <Link
            to="/browse"
            className={`px-4 py-2 rounded transition-colors duration-150 ${isActive("/browse")}`}
          >
            Browse Gear
          </Link>
        </nav>
      </div>
    </header>
  );
}
