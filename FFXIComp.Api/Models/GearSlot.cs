using System.ComponentModel.DataAnnotations;

namespace FFXIComp.Api.Models;

public class GearSlot
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;  // e.g. "Main", "Sub", "Head", etc.

    public ICollection<GearItemSlot> GearItemSlots { get; set; } = new List<GearItemSlot>();
}