using System.ComponentModel.DataAnnotations;

namespace GearForgeXI.Models;

public class Stat
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;       // Canonical name: "STR", "Store TP"

    public string? DisplayName { get; set; }        // Optional: full name like "Strength"

    public string? AlternateName1 { get; set; }     // First alternative name/abbreviation

    public string? AlternateName2 { get; set; }     // Second alternative name/abbreviation

    public StatCategory? Category { get; set; }     // e.g. "Base", "Combat", "Magic", etc.

    public string? Description { get; set; }        // Optional tooltip text

    public ICollection<GearItemStat> GearItemStats { get; set; } = new List<GearItemStat>();
}