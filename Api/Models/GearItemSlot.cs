using System.ComponentModel.DataAnnotations;

namespace FFXIComp.Api.Models;

public class GearItemSlot
{
    [Key]
    public int Id { get; set; }

    public int GearItemId { get; set; }
    public GearItem GearItem { get; set; } = null!;

    public int GearSlotId { get; set; }
    public GearSlot GearSlot { get; set; } = null!;
}