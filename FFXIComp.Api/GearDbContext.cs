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
                var head1Items = Head1SeedData.GetItems();
                context.GearItems.AddRange(head1Items);

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

                var bodyItems = Body1SeedData.GetItems();
                context.GearItems.AddRange(bodyItems);

                var body2Items = Body2SeedData.GetItems();
                context.GearItems.AddRange(body2Items);

                var body3Items = Body3SeedData.GetItems();
                context.GearItems.AddRange(body3Items);

                var body4Items = Body4SeedData.GetItems();
                context.GearItems.AddRange(body4Items);

                var handsItems = Hands1SeedData.GetItems();
                context.GearItems.AddRange(handsItems);

                var hands2Items = Hands2SeedData.GetItems();
                context.GearItems.AddRange(hands2Items);

                var hands3Items = Hands3SeedData.GetItems();
                context.GearItems.AddRange(hands3Items);

                var hands4Items = Hands4SeedData.GetItems();
                context.GearItems.AddRange(hands4Items);

                var feet1Items = Feet1SeedData.GetItems();
                context.GearItems.AddRange(feet1Items);

                var feet2Items = Feet2SeedData.GetItems();
                context.GearItems.AddRange(feet2Items);

                var feet3Items = Feet3SeedData.GetItems();
                context.GearItems.AddRange(feet3Items);

                var feet4Items = Feet4SeedData.GetItems();
                context.GearItems.AddRange(feet4Items);

                var backItems = BackSeedData.GetItems();
                context.GearItems.AddRange(backItems);

                var main1Items = Main1SeedData.GetItems();
                context.GearItems.AddRange(main1Items);

                var main2Items = Main2SeedData.GetItems();
                context.GearItems.AddRange(main2Items);

                var main3Items = Main3SeedData.GetItems();
                context.GearItems.AddRange(main3Items);

                var main4Items = Main4SeedData.GetItems();
                context.GearItems.AddRange(main4Items);

                var main5Items = Main5SeedData.GetItems();
                context.GearItems.AddRange(main5Items);

                var main6Items = Main6SeedData.GetItems();
                context.GearItems.AddRange(main6Items);

                var subItems = SubSeedData.GetItems();
                context.GearItems.AddRange(subItems);

                context.SaveChanges();
            }
        }
    }
}
