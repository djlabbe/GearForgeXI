using System.ComponentModel.DataAnnotations;

namespace GearForgeXI.Models;

// Represents an item in a gear set, linking a gear item to a specific position.
public class GearSetItem
{
    public int Id { get; set; }

    // Foreign key to GearSet
    public int GearSetId { get; set; }
    public GearSet GearSet { get; set; } = null!;

    // Foreign key to GearItem
    public int GearItemId { get; set; }
    public GearItem GearItem { get; set; } = null!;

    // Position of the gear item in the set (e.g. "main", "sub", "head", "ear1", "ear2", "ring1", "ring2")
    [Required]
    public SetPosition Position { get; set; }
}