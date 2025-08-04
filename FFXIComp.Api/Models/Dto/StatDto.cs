using System.ComponentModel.DataAnnotations;

namespace FFXIComp.Api.Models.Dto
{
    public class StatDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;       // Canonical name: "STR", "Store TP"

        public string? DisplayName { get; set; }        // Optional: full name like "Strength"

        public string? Category { get; set; }           // e.g. "Base", "Combat", "Magic", etc.

        public string? Description { get; set; }        // Optional tooltip text

    }
}