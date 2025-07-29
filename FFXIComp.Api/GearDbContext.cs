using Microsoft.EntityFrameworkCore;
using FFXIComp.Api.Models;
using FFXIComp.Api.SeedData;

namespace FFXIComp.Api
{
    public class GearDbContext : DbContext
    {
        public GearDbContext(DbContextOptions<GearDbContext> options) : base(options) { }

        public DbSet<GearItem> GearItems { get; set; } = null!;
        public DbSet<GearStat> GearStats { get; set; } = null!;
        public DbSet<GearItemJob> GearItemJobs { get; set; } = null!;

        public string[] allJobs = new[]
            {
            "WAR", "MNK", "WHM", "BLM", "RDM", "THF", "PLD", "DRK",
            "BST", "BRD", "RNG", "SAM", "NIN", "DRG", "SMN", "BLU",
            "COR", "PUP", "DNC", "SCH", "GEO", "RUN"
        };

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure one-to-many: GearItem -> GearStats
            modelBuilder.Entity<GearStat>()
                .HasOne(gs => gs.GearItem)
                .WithMany(gi => gi.GearStats)
                .HasForeignKey(gs => gs.GearItemId);

            // Configure one-to-many: GearItem -> GearItemJobs
            modelBuilder.Entity<GearItemJob>()
                .HasOne(gij => gij.GearItem)
                .WithMany(gi => gi.GearItemJobs)
                .HasForeignKey(gij => gij.GearItemId);
        }

        public static void SeedInitialData(GearDbContext context)
        {
            if (!context.GearItems.Any())
            {
                var headItems = HeadSeedData.GetItems();
                context.GearItems.AddRange(headItems);
                var neckItems = NeckSeedData.GetItems();
                context.GearItems.AddRange(neckItems);
                context.SaveChanges();
            }
        }
    }
}
