import { Link, useLocation } from "react-router-dom";

export function Navbar() {
  const location = useLocation();

  const isActive = (path: string) =>
    location.pathname === path
      ? "text-white bg-blue-700"
      : "text-blue-100 hover:text-white hover:bg-blue-600";

  return (
    <header className="bg-black text-white shadow mb-6">
      <div className=" mx-auto px-4 py-4 flex items-center justify-between">
        <h1 className="text-2xl font-bold">FFXI Compare</h1>
        <nav className="space-x-2">
          <Link
            to="/"
            className={`px-4 py-2 rounded transition ${isActive("/")}`}
          >
            Compare Sets
          </Link>
          <Link
            to="/browse"
            className={`px-4 py-2 rounded transition ${isActive("/browse")}`}
          >
            Browse Gear
          </Link>
        </nav>
      </div>
    </header>
  );
}
