using System.ComponentModel.DataAnnotations;

namespace FFXIComp.Api.Models;

public class GearSet
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    // Navigation
    public ICollection<GearSetSlot> GearSetSlots { get; set; } = new List<GearSetSlot>();

    // For future: public string? UserId { get; set; }
}
