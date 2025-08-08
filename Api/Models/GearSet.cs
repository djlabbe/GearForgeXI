using System.ComponentModel.DataAnnotations;

namespace GearForgeXI.Models;

public class GearSet
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    // Foreign key to User
    [Required]
    public string UserId { get; set; } = null!;

    // Foreign key to Job
    [Required]
    public int JobId { get; set; }

    // Navigation properties
    public ApplicationUser User { get; set; } = null!;
    public Job Job { get; set; } = null!;

    public ICollection<GearSetItem> GearSetItems { get; set; } = new List<GearSetItem>();

    public bool HasPositionFilled(SetPosition position)
    {
        return GearSetItems.Any(item => item.Position == position);
    }

    public GearSetItem? GetItemAtPosition(SetPosition position)
    {
        return GearSetItems.FirstOrDefault(item => item.Position == position);
    }

    public bool CanAddItem(SetPosition position)
    {
        return !HasPositionFilled(position);
    }

    public void AddOrUpdateSlot(GearItem gearItem, SetPosition position)
    {
        var existingSlot = GetItemAtPosition(position);

        if (existingSlot != null)
        {
            // Update existing slot
            existingSlot.GearItemId = gearItem.Id;
            existingSlot.GearItem = gearItem;
        }
        else
        {
            // Add new slot
            var newItem = new GearSetItem
            {
                GearSetId = Id,
                GearSet = this,
                GearItemId = gearItem.Id,
                GearItem = gearItem,
                Position = position
            };

            GearSetItems.Add(newItem);
        }
    }

    public bool RemoveItemAtPosition(SetPosition position)
    {
        var item = GetItemAtPosition(position);
        if (item != null)
        {
            GearSetItems.Remove(item);
            return true;
        }
        return false;
    }

    public void ValidateItemPositions()
    {
        var positions = GearSetItems.Select(item => item.Position).ToList();
        var duplicates = positions.GroupBy(p => p)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .ToList();

        if (duplicates.Count != 0)
        {
            throw new InvalidOperationException($"GearSet contains duplicate items: {string.Join(", ", duplicates)}");
        }
    }
}
