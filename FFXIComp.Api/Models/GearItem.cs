using System.ComponentModel.DataAnnotations;

namespace FFXIComp.Api.Models
{
    public class GearItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public int? GearItemCategoryId { get; set; } // Nullable FK
        public GearItemCategory? Category { get; set; } // Navigation property to GearCategory

        // Navigation properties
        [Required]
        public ICollection<GearItemSlot> GearItemSlots { get; set; } = new List<GearItemSlot>(); // Many-to-many relationship with GearSlot
        public ICollection<GearItemJob> GearItemJobs { get; set; } = new List<GearItemJob>();  // Many-to-many relationship with Job
        public ICollection<GearStat> GearStats { get; set; } = new List<GearStat>(); // One-to-many relationship with GearStat
    }
}
