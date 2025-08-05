export interface GearItemSlotUpdateDto {
  slots: string[];
}

class ApiService {
  private static baseUrl = '/api';

  static async getAvailableSlots(): Promise<string[]> {
    const response = await fetch(`${this.baseUrl}/gear/slots`);
    if (!response.ok) {
      throw new Error(`Failed to fetch available slots: ${response.statusText}`);
    }
    return response.json();
  }

  static async updateGearItemSlots(itemId: number, slots: string[]): Promise<void> {
    const response = await fetch(`${this.baseUrl}/gear/${itemId}/slots`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify({ slots } as GearItemSlotUpdateDto),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update gear item slots: ${errorText}`);
    }
  }
}

export default ApiService;
