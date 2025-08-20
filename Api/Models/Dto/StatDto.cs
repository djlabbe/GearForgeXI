using System.ComponentModel.DataAnnotations;

namespace GearForgeXI.Models.Dto
{
    public class StatDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;       // Canonical name: "STR", "Store TP"

        public string? DisplayName { get; set; }        // Optional: full name like "Strength"

        public string? AlternateName1 { get; set; }     // First alternative name/abbreviation

        public string? AlternateName2 { get; set; }     // Second alternative name/abbreviation

        public string? Category { get; set; }           // e.g. "Base", "Combat", "Magic", etc.

        public string? Description { get; set; }        // Optional tooltip text

        public bool IsBaseStat { get; set; }           // True for base stats (STR, DEX, VIT, AGI, INT, MND, CHR)

        public int GearItemCount { get; set; }
        public int BaseStatCount { get; set; }
        public int JobTraitCount { get; set; }
        public int JobPointBonusCount { get; set; }
        public int JobGiftCount { get; set; }
        public int MasterLevelBonusCount { get; set; }

        public bool CanDelete { get; set; }
    }
}