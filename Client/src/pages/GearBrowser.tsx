import { useEffect, useState, useMemo } from "react";
import InfiniteScroll from "react-infinite-scroll-component";
import type { GearItem } from "../models/GearItem";
import Card from "../components/Card";
import GearItemCard from "../components/GearItemCard";
import GearItemModal from "../components/GearItemModal";
import { useAppData } from "../contexts/AppDataContext";
import { useAuth } from "../contexts/AuthContext";

// May want to add true virtual scrolling later
export function GearBrowser() {
  const { jobs, slots, loading: loadingAppData } = useAppData();
  const { isAdmin } = useAuth();

  const [gearItems, setGearItems] = useState<GearItem[]>([]);
  const [filter, setFilter] = useState("");
  const [loading, setLoading] = useState(false);
  const [selectedSlot, setSelectedSlot] = useState<string>("");
  const [selectedJob, setSelectedJob] = useState<string>("");
  const [showCreateModal, setShowCreateModal] = useState(false);
  const [editingItem, setEditingItem] = useState<GearItem | null>(null);
  
  // Infinite scroll state
  const [displayedItems, setDisplayedItems] = useState<GearItem[]>([]);
  const [hasMore, setHasMore] = useState(true);
  const ITEMS_PER_PAGE = 50;

  const handleItemUpdatedOrCreated = (item: GearItem, isEdit: boolean) => {
    if (isEdit) {
      // Update existing item
      setGearItems((prevItems) =>
        prevItems.map((prevItem) => (prevItem.id === item.id ? item : prevItem))
      );
    } else {
      // Add new item
      setGearItems((prevItems) => [...prevItems, item]);
    }
  };

  const handleEditItem = (item: GearItem) => {
    setEditingItem(item);
  };

  const handleCloseModal = () => {
    setShowCreateModal(false);
    setEditingItem(null);
  };

  const loadMoreItems = () => {
    const currentLength = displayedItems.length;
    const moreItems = filteredItems.slice(currentLength, currentLength + ITEMS_PER_PAGE);
    
    if (moreItems.length === 0) {
      setHasMore(false);
      return;
    }
    
    setDisplayedItems(prev => [...prev, ...moreItems]);
    setHasMore(currentLength + moreItems.length < filteredItems.length);
  };

  const resetDisplayedItems = (items: GearItem[]) => {
    const initialItems = items.slice(0, ITEMS_PER_PAGE);
    setDisplayedItems(initialItems);
    setHasMore(items.length > ITEMS_PER_PAGE);
  };

  useEffect(() => {
    // Only fetch data if both job and slot are selected
    if (!selectedJob || !selectedSlot) {
      setGearItems([]);
      return;
    }

    setLoading(true);
    fetch(`/api/gear?job=${encodeURIComponent(selectedJob)}&slot=${encodeURIComponent(selectedSlot)}`)
      .then((res) => res.json())
      .then((items: GearItem[]) => {
        setGearItems(items);
      })
      .finally(() => setLoading(false));
  }, [selectedJob, selectedSlot]);

  const filteredItems = useMemo(() => {
    // Since we're fetching filtered data from API, just apply name filter
    return gearItems.filter((item) =>
      item.name.toLowerCase().includes(filter.toLowerCase())
    );
  }, [gearItems, filter]);

  // Reset displayed items when filters change
  useEffect(() => {
    resetDisplayedItems(filteredItems);
  }, [filteredItems]);

  if (loadingAppData) {
    return (
      <div className="flex items-center justify-center min-h-screen">
        <div className="text-gray-600 dark:text-gray-400">Loading...</div>
      </div>
    );
  }

  return (
    <div className="bg-white dark:bg-gray-900 min-h-screen">
      <div className="flex justify-between items-center mb-4">
        <h1 className="text-2xl font-bold text-gray-900 dark:text-white">
          {isAdmin ? "Gear Admin" : "Gear Browser"}
        </h1>
        {isAdmin && (
          <button
            onClick={() => setShowCreateModal(true)}
            className="px-4 py-2 bg-blue-600 hover:bg-blue-700 text-white rounded-lg transition-colors duration-200 font-medium cursor-pointer disabled:opacity-50 disabled:cursor-not-allowed"
          >
            Add New Gear
          </button>
        )}
      </div>
      <Card className="mb-2">
        <h2 className="text-xl font-bold mb-4 text-gray-900 dark:text-gray-100">
          Filter
        </h2>
        <input
          type="text"
          placeholder="Filter by name..."
          value={filter}
          onChange={(e) => setFilter(e.target.value)}
          className="mb-4 p-2 border border-gray-300 dark:border-gray-700 rounded w-full bg-white dark:bg-gray-800 text-gray-900 dark:text-gray-100 placeholder-gray-400 dark:placeholder-gray-500"
        />
        <div className="flex space-x-2 mb-2 flex-wrap">
          {slots.map((slot) => (
            <button
              key={slot}
              onClick={() => setSelectedSlot(slot)}
              className={`px-3 py-1 my-1 rounded w-24 text-center cursor-pointer disabled:opacity-50 disabled:cursor-not-allowed ${
                selectedSlot === slot
                  ? "bg-blue-600 text-white"
                  : "bg-gray-200 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
              }`}
              style={{ minWidth: "6rem" }}
            >
              {slot}
            </button>
          ))}
        </div>
        <div className="flex space-x-2 mb-2 flex-wrap">
          {jobs.map((job) => (
            <button
              key={job.abbreviation}
              onClick={() => setSelectedJob(job.abbreviation)}
              className={`px-3 py-1 my-1 rounded w-24 cursor-pointer disabled:opacity-50 disabled:cursor-not-allowed ${
                selectedJob === job.abbreviation
                  ? "bg-blue-600 text-white"
                  : "bg-gray-200 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
              }`}
            >
              {job.abbreviation}
            </button>
          ))}
        </div>
      </Card>

      {/* Selection Prompt */}
      {!selectedJob || !selectedSlot ? (
        <Card className="text-center py-12">
          <div className="text-gray-600 dark:text-gray-400">
            <h3 className="text-lg font-medium mb-2">Select Job and Slot</h3>
            <p>Please select both a job and a slot to view available gear items.</p>
            {!selectedJob && !selectedSlot && (
              <p className="mt-2 text-sm">Start by choosing a job and slot above.</p>
            )}
            {selectedJob && !selectedSlot && (
              <p className="mt-2 text-sm">Now select a slot to see {selectedJob} gear.</p>
            )}
            {!selectedJob && selectedSlot && (
              <p className="mt-2 text-sm">Now select a job to see {selectedSlot} gear.</p>
            )}
          </div>
        </Card>
      ) : loading ? (
        <Card className="text-center py-12">
          <div className="text-gray-600 dark:text-gray-400">
            <div className="animate-spin rounded-full h-8 w-8 border-b-2 border-blue-600 mx-auto mb-2"></div>
            Loading {selectedJob} {selectedSlot} gear...
          </div>
        </Card>
      ) : (
        <InfiniteScroll
          dataLength={displayedItems.length}
          next={loadMoreItems}
          hasMore={hasMore}
          loader={
            <div className="col-span-full flex justify-center py-4">
              <div className="animate-spin rounded-full h-8 w-8 border-b-2 border-blue-600"></div>
            </div>
          }
          endMessage={
            <div className="col-span-full text-center py-4 text-gray-600 dark:text-gray-400">
              {displayedItems.length === 0 
                ? `No ${selectedSlot} gear found for ${selectedJob}` 
                : `Showing all ${displayedItems.length} items`
              }
            </div>
          }
        >
          <div className="grid grid-cols-1 md:grid-cols-3 lg:grid-cols-4 xl:grid-cols-5 gap-2">
            {displayedItems.map((item) => (
              <GearItemCard
                key={item.id}
                item={item}
                onEditItem={handleEditItem}
                showEditButton={isAdmin}
              />
            ))}
          </div>
        </InfiniteScroll>
      )}

      {/* Create/Edit Gear Item Modal - Only for Admin users */}
      {isAdmin && (
        <GearItemModal
          isOpen={showCreateModal || editingItem !== null}
          onClose={handleCloseModal}
          onItemCreated={handleItemUpdatedOrCreated}
          editingItem={editingItem}
        />
      )}
    </div>
  );
}
