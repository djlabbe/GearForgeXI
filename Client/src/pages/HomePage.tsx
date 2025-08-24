import { Link } from "react-router-dom";
import Card from "../components/Card";

const HomePage = () => {
  return (
    <div className="max-w-6xl mx-auto space-y-8">
      {/* Hero Section */}
      <div className="text-center py-12">
        <h1 className="text-4xl font-bold text-gray-900 dark:text-white mb-4">
          Welcome to GearForgeXI
        </h1>
        <p className="text-xl text-gray-600 dark:text-gray-300 mb-8">
          Your ultimate tool for Final Fantasy XI gear optimization and character builds
        </p>
        <div className="flex justify-center gap-4">
          <Link
            to="/build"
            className="bg-blue-600 hover:bg-blue-700 text-white px-6 py-3 rounded-lg font-medium transition-colors"
          >
            Build Equip Set
          </Link>
          <Link
            to="/compare"
            className="bg-green-600 hover:bg-green-700 text-white px-6 py-3 rounded-lg font-medium transition-colors"
          >
            Compare Sets
          </Link>
        </div>
      </div>

      {/* Feature Cards */}
      <div className="grid md:grid-cols-2 lg:grid-cols-3 gap-6">
        <Card>
          <div className="p-6">
            <div className="text-blue-600 dark:text-blue-400 mb-4">
              <svg className="w-8 h-8" fill="currentColor" viewBox="0 0 20 20">
                <path d="M9 12l2 2 4-4m6 2a9 9 0 11-18 0 9 9 0 0118 0z" />
              </svg>
            </div>
            <h3 className="text-xl font-semibold mb-2">Build Gear Sets</h3>
            <p className="text-gray-600 dark:text-gray-300 mb-4">
              Create optimized gear configurations for any job and situation.
            </p>
            <Link
              to="/build"
              className="text-blue-600 dark:text-blue-400 hover:underline font-medium"
            >
              Start Building →
            </Link>
          </div>
        </Card>

        <Card>
          <div className="p-6">
            <div className="text-green-600 dark:text-green-400 mb-4">
              <svg className="w-8 h-8" fill="currentColor" viewBox="0 0 20 20">
                <path d="M3 4a1 1 0 011-1h12a1 1 0 011 1v2a1 1 0 01-1 1H4a1 1 0 01-1-1V4zM3 10a1 1 0 011-1h6a1 1 0 011 1v6a1 1 0 01-1 1H4a1 1 0 01-1-1v-6zM14 9a1 1 0 00-1 1v6a1 1 0 001 1h2a1 1 0 001-1v-6a1 1 0 00-1-1h-2z" />
              </svg>
            </div>
            <h3 className="text-xl font-semibold mb-2">Compare Sets</h3>
            <p className="text-gray-600 dark:text-gray-300 mb-4">
              Side-by-side comparison of your saved gear sets and their stats.
            </p>
            <Link
              to="/compare"
              className="text-green-600 dark:text-green-400 hover:underline font-medium"
            >
              Compare Now →
            </Link>
          </div>
        </Card>

        <Card>
          <div className="p-6">
            <div className="text-purple-600 dark:text-purple-400 mb-4">
              <svg className="w-8 h-8" fill="currentColor" viewBox="0 0 20 20">
                <path d="M9 2a1 1 0 000 2h2a1 1 0 100-2H9z" />
                <path fillRule="evenodd" d="M4 5a2 2 0 012-2v1a1 1 0 102 0V3a2 2 0 012-2h1a2 2 0 012 2v1a1 1 0 102 0V3a2 2 0 012-2 2 2 0 012 2v11a2 2 0 01-2 2H4a2 2 0 01-2-2V5zm3 4a1 1 0 000 2h.01a1 1 0 100-2H7zm3 0a1 1 0 000 2h3a1 1 0 100-2h-3zm-3 4a1 1 0 100 2h.01a1 1 0 100-2H7zm3 0a1 1 0 100 2h3a1 1 0 100-2h-3z" clipRule="evenodd" />
              </svg>
            </div>
            <h3 className="text-xl font-semibold mb-2">Browse Gear</h3>
            <p className="text-gray-600 dark:text-gray-300 mb-4">
              Explore the complete database of gear items and their statistics.
            </p>
            <Link
              to="/gear"
              className="text-purple-600 dark:text-purple-400 hover:underline font-medium"
            >
              Browse Gear →
            </Link>
          </div>
        </Card>

        <Card>
          <div className="p-6">
            <div className="text-red-600 dark:text-red-400 mb-4">
              <svg className="w-8 h-8" fill="currentColor" viewBox="0 0 20 20">
                <path d="M13 6a3 3 0 11-6 0 3 3 0 016 0zM18 8a2 2 0 11-4 0 2 2 0 014 0zM14 15a4 4 0 00-8 0v3h8v-3z" />
              </svg>
            </div>
            <h3 className="text-xl font-semibold mb-2">Character Simulator</h3>
            <p className="text-gray-600 dark:text-gray-300 mb-4">
              Simulate your character's actual in-game statistics with different gear combinations.
            </p>
            <Link
              to="/simulator"
              className="text-red-600 dark:text-red-400 hover:underline font-medium"
            >
              Simulate →
            </Link>
          </div>
        </Card>

        <Card>
          <div className="p-6">
            <div className="text-indigo-600 dark:text-indigo-400 mb-4">
              <svg className="w-8 h-8" fill="currentColor" viewBox="0 0 20 20">
                <path d="M2 11a1 1 0 011-1h2a1 1 0 011 1v5a1 1 0 01-1 1H3a1 1 0 01-1-1v-5zM8 7a1 1 0 011-1h2a1 1 0 011 1v9a1 1 0 01-1 1H9a1 1 0 01-1-1V7zM14 4a1 1 0 011-1h2a1 1 0 011 1v12a1 1 0 01-1 1h-2a1 1 0 01-1-1V4z" />
              </svg>
            </div>
            <h3 className="text-xl font-semibold mb-2">Stats Overview</h3>
            <p className="text-gray-600 dark:text-gray-300 mb-4">
              View item statistics and quickly find gear with relevant stats.
            </p>
            <Link
              to="/stats"
              className="text-indigo-600 dark:text-indigo-400 hover:underline font-medium"
            >
              View Stats →
            </Link>
          </div>
        </Card>

        <Card>
          <div className="p-6">
            <div className="text-yellow-600 dark:text-yellow-400 mb-4">
              <svg className="w-8 h-8" fill="currentColor" viewBox="0 0 20 20">
                <path fillRule="evenodd" d="M18 10a8 8 0 11-16 0 8 8 0 0116 0zm-6-3a2 2 0 11-4 0 2 2 0 014 0zm-2 4a5 5 0 00-4.546 2.916A5.986 5.986 0 0010 16a5.986 5.986 0 004.546-2.084A5 5 0 0010 11z" clipRule="evenodd" />
              </svg>
            </div>
            <h3 className="text-xl font-semibold mb-2">Character Profiles</h3>
            <p className="text-gray-600 dark:text-gray-300 mb-4">
              Manage your character profiles and configurations.
            </p>
            <Link
              to="/profiles"
              className="text-yellow-600 dark:text-yellow-400 hover:underline font-medium"
            >
              Manage Profiles →
            </Link>
          </div>
        </Card>
      </div>
    </div>
  );
};

export default HomePage;
