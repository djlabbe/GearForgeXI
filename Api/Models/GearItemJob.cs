using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FFXIComp.Api.Models
{
    // Many-to-many join table: GearItem <-> Job
    public class GearItemJob
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int JobId { get; set; }

        [JsonIgnore]
        public Job Job { get; set; } = null!;

        [JsonIgnore]
        public int GearItemId { get; set; }

        [JsonIgnore]
        public GearItem GearItem { get; set; } = null!;
    }
}