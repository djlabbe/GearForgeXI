using FFXIComp.Api.SeedData;
using Microsoft.EntityFrameworkCore;
using FFXIComp.Api.Models;

namespace FFXIComp.Api
{
    public class GearDbContext : DbContext
    {
        public GearDbContext(DbContextOptions<GearDbContext> options) : base(options) { }

        public DbSet<GearItem> GearItems { get; set; } = null!;
        public DbSet<GearStat> GearStats { get; set; } = null!;
        public DbSet<GearItemJob> GearItemJobs { get; set; } = null!;

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

                var ammoItems = AmmoSeedData.GetItems();
                context.GearItems.AddRange(ammoItems);

                var earItems = EarSeedData.GetItems();
                context.GearItems.AddRange(earItems);

                var ringItems = RingSeedData.GetItems();
                context.GearItems.AddRange(ringItems);

                var waistItems = WaistSeedData.GetItems();
                context.GearItems.AddRange(waistItems);

                var legsItems = LegsSeedData.GetItems();
                context.GearItems.AddRange(legsItems);

                var legs2Items = Legs2SeedData.GetItems();
                context.GearItems.AddRange(legs2Items);

                var legs3Items = Legs3SeedData.GetItems();
                context.GearItems.AddRange(legs3Items);

                var legs4Items = Legs4SeedData.GetItems();
                context.GearItems.AddRange(legs4Items);
                
                context.SaveChanges();
            }
        }
    }
}
