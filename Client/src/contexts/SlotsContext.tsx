import { createContext, useContext, useEffect, useState } from 'react';
import type { ReactNode } from 'react';
import ApiService from '../utils/apiService';

interface SlotsContextType {
  slots: string[];
  loading: boolean;
  error: string | null;
}

const SlotsContext = createContext<SlotsContextType | undefined>(undefined);

export const useSlots = () => {
  const context = useContext(SlotsContext);
  if (context === undefined) {
    throw new Error('useSlots must be used within a SlotsProvider');
  }
  return context;
};

interface SlotsProviderProps {
  children: ReactNode;
}

export const SlotsProvider = ({ children }: SlotsProviderProps) => {
  const [availableSlots, setAvailableSlots] = useState<string[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  const fetchSlots = async () => {
    try {
      setLoading(true);
      setError(null);
      const slots = await ApiService.getAvailableSlots();
      setAvailableSlots(slots);
    } catch (err) {
      setError(err instanceof Error ? err.message : 'Failed to fetch slots');
    } finally {
      setLoading(false);
    }
  };

  useEffect(() => {
    fetchSlots();
  }, []);

  const value: SlotsContextType = {
    slots: availableSlots,
    loading,
    error,
  };

  return (
    <SlotsContext.Provider value={value}>
      {children}
    </SlotsContext.Provider>
  );
};
