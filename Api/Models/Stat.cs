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

    public bool IsBaseStat => Category == StatCategory.Base;   // True for STR, DEX, VIT, AGI, INT, MND, CHR

    public string? Description { get; set; }        // Optional tooltip text

    public ICollection<GearItemStat> GearItemStats { get; set; } = [];
    public ICollection<JobBaseStat> JobBaseStats { get; set; } = [];
    public ICollection<JobTrait> JobTraits { get; set; } = [];
    public ICollection<JobPointBonus> JobPointBonuses { get; set; } = [];
    public ICollection<JobGift> JobGifts { get; set; } = [];
    public ICollection<MasterLevelBonus> MasterLevelBonuses { get; set; } = [];

    public bool CanDelete => GearItemStats.Count == 0 && JobBaseStats.Count == 0 && JobTraits.Count == 0 && JobPointBonuses.Count == 0 && JobGifts.Count == 0 && MasterLevelBonuses.Count == 0;
}