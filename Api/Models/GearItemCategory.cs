using System.ComponentModel.DataAnnotations;

namespace GearForgeXI.Models;

public class GearItemCategory
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;  // e.g. "2H", "1H", "H2H", "Cloak", "Instrument", "Bow", "Crossbow", "Gun", "Arrow", "Bolt", "Bullet", "Ammo"

    public ICollection<GearItem> GearItems { get; set; } = [];
}