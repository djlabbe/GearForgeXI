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
        public bool Verified { get; set; } = false; // Indicates if the item stats have been verified.

        // Navigation properties
        [Required]
        public ICollection<GearItemSlot> GearItemSlots { get; set; } = new List<GearItemSlot>(); // Many-to-many relationship with GearSlot
        public ICollection<GearItemJob> GearItemJobs { get; set; } = new List<GearItemJob>();  // Many-to-many relationship with Job
        public ICollection<GearItemStat> GearItemStats { get; set; } = new List<GearItemStat>(); // Many-to-many relationship with GearItemStat
    }
}
