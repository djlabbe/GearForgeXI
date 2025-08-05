using System.ComponentModel.DataAnnotations;

namespace FFXIComp.Api.Models;

public class GearSetSlot
{
    public int Id { get; set; }

    public int GearSetId { get; set; }
    public GearSet GearSet { get; set; } = null!;

    public int GearSlotId { get; set; }
    public GearSlot GearSlot { get; set; } = null!;

    public int GearItemId { get; set; }
    public GearItem GearItem { get; set; } = null!;

    [Required]
    public string Position { get; set; } = null!; // e.g. "ear1", "ring2"
}