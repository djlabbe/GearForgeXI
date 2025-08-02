
using Microsoft.EntityFrameworkCore;
using FFXIComp.Api.Models;
using FFXIComp.Api.SeedData;

namespace FFXIComp.Api
{
    public class GearDbContext : DbContext
    {
        public GearDbContext(DbContextOptions<GearDbContext> options) : base(options) { }
        public DbSet<GearItem> GearItems { get; set; }
        public DbSet<GearStat> GearStats { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<GearSlot> GearSlots { get; set; }
        public DbSet<GearItemCategory> GearItemCategories { get; set; }
        public DbSet<GearItemJob> GearItemJobs { get; set; }
        public DbSet<GearItemSlot> GearItemSlots { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Jobs
            modelBuilder.Entity<Job>().HasData(
                new Job { Id = 1, Abbreviation = "WAR", FullName = "Warrior" },
                new Job { Id = 2, Abbreviation = "MNK", FullName = "Monk" },
                new Job { Id = 3, Abbreviation = "WHM", FullName = "White Mage" },
                new Job { Id = 4, Abbreviation = "BLM", FullName = "Black Mage" },
                new Job { Id = 5, Abbreviation = "RDM", FullName = "Red Mage" },
                new Job { Id = 6, Abbreviation = "THF", FullName = "Thief" },
                new Job { Id = 7, Abbreviation = "PLD", FullName = "Paladin" },
                new Job { Id = 8, Abbreviation = "DRK", FullName = "Dark Knight" },
                new Job { Id = 9, Abbreviation = "BST", FullName = "Beastmaster" },
                new Job { Id = 10, Abbreviation = "BRD", FullName = "Bard" },
                new Job { Id = 11, Abbreviation = "RNG", FullName = "Ranger" },
                new Job { Id = 12, Abbreviation = "SAM", FullName = "Samurai" },
                new Job { Id = 13, Abbreviation = "NIN", FullName = "Ninja" },
                new Job { Id = 14, Abbreviation = "DRG", FullName = "Dragoon" },
                new Job { Id = 15, Abbreviation = "SMN", FullName = "Summoner" },
                new Job { Id = 16, Abbreviation = "BLU", FullName = "Blue Mage" },
                new Job { Id = 17, Abbreviation = "COR", FullName = "Corsair" },
                new Job { Id = 18, Abbreviation = "PUP", FullName = "Puppetmaster" },
                new Job { Id = 19, Abbreviation = "DNC", FullName = "Dancer" },
                new Job { Id = 20, Abbreviation = "SCH", FullName = "Scholar" },
                new Job { Id = 21, Abbreviation = "GEO", FullName = "Geomancer" },
                new Job { Id = 22, Abbreviation = "RUN", FullName = "Rune Fencer" }
            );

            // Seed GearSlots
            modelBuilder.Entity<GearSlot>().HasData(
                new GearSlot { Id = 1, Name = "Main" },
                new GearSlot { Id = 2, Name = "Sub" },
                new GearSlot { Id = 3, Name = "Range" },
                new GearSlot { Id = 4, Name = "Ammo" },
                new GearSlot { Id = 5, Name = "Head" },
                new GearSlot { Id = 6, Name = "Neck" },
                new GearSlot { Id = 7, Name = "Ear" },
                new GearSlot { Id = 8, Name = "Body" },
                new GearSlot { Id = 9, Name = "Hands" },
                new GearSlot { Id = 10, Name = "Ring" },
                new GearSlot { Id = 11, Name = "Back" },
                new GearSlot { Id = 12, Name = "Waist" },
                new GearSlot { Id = 13, Name = "Legs" },
                new GearSlot { Id = 14, Name = "Feet" }
            );

            // Seed GearCategories
            modelBuilder.Entity<GearItemCategory>().HasData(
                new GearItemCategory { Id = 1, Name = "1H" }, //Done
                new GearItemCategory { Id = 2, Name = "2H" }, //Done
                new GearItemCategory { Id = 3, Name = "H2H" },//Done
                new GearItemCategory { Id = 4, Name = "Shield" }, //Done
                new GearItemCategory { Id = 5, Name = "Grip" }, // Done
                new GearItemCategory { Id = 6, Name = "Instrument" },
                new GearItemCategory { Id = 7, Name = "Bow" },
                new GearItemCategory { Id = 8, Name = "Crossbow" },
                new GearItemCategory { Id = 9, Name = "Gun" },
                new GearItemCategory { Id = 10, Name = "Arrow" }, //Done
                new GearItemCategory { Id = 11, Name = "Bolt" }, //Done
                new GearItemCategory { Id = 12, Name = "Bullet" }, //Done
                new GearItemCategory { Id = 13, Name = "Ammo" }, //Done
                new GearItemCategory { Id = 14, Name = "Cloak" }, //Done
                new GearItemCategory { Id = 15, Name = "Thrown" } //Done
            );

            // GearItem → GearCategory
            modelBuilder.Entity<GearItem>()
              .HasOne(g => g.Category)
              .WithMany(c => c.GearItems)
              .HasForeignKey(g => g.GearItemCategoryId)
              .IsRequired(false);

            // GearItem → GearStats
            modelBuilder.Entity<GearStat>()
                .HasOne(gs => gs.GearItem)
                .WithMany(gi => gi.GearStats)
                .HasForeignKey(gs => gs.GearItemId);

            // GearItem → GearItemJobs
            modelBuilder.Entity<GearItemJob>()
                .HasOne(gij => gij.GearItem)
                .WithMany(gi => gi.GearItemJobs)
                .HasForeignKey(gij => gij.GearItemId);

            // GearItemJob → Job
            modelBuilder.Entity<GearItemJob>()
                .HasOne(gij => gij.Job)
                .WithMany(j => j.GearItemJobs)
                .HasForeignKey(gij => gij.JobId);

            // GearItem → GearItemSlots
            modelBuilder.Entity<GearItemSlot>()
                .HasOne(gis => gis.GearItem)
                .WithMany(gi => gi.GearItemSlots)
                .HasForeignKey(gis => gis.GearItemId);

            // GearItemSlot → GearSlot
            modelBuilder.Entity<GearItemSlot>()
                .HasOne(gis => gis.GearSlot)
                .WithMany(gs => gs.GearItemSlots)
                .HasForeignKey(gis => gis.GearSlotId);



            // Optional: Prevent duplicates
            modelBuilder.Entity<GearItemSlot>()
                .HasIndex(gis => new { gis.GearItemId, gis.GearSlotId })
                .IsUnique();

            modelBuilder.Entity<GearItemJob>()
                .HasIndex(gij => new { gij.GearItemId, gij.JobId })
                .IsUnique();

        }

        public static void SeedInitialData(GearDbContext context)
        {
            if (!context.GearItems.Any())
            {
                var main1Items = Main1SeedData.GetItems();
                context.GearItems.AddRange(main1Items);

                context.GearItems.AddRange(Main2H.GetItems());
                context.GearItems.AddRange(MainH2HSeedData.GetItems());
                context.GearItems.AddRange(ShieldSeedData.GetItems());


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

                var bodyItems = Body1SeedData.GetItems();
                context.GearItems.AddRange(bodyItems);

                var handsItems = Hands1SeedData.GetItems();
                context.GearItems.AddRange(handsItems);

                var feet2Items = Feet2SeedData.GetItems();
                context.GearItems.AddRange(feet2Items);

                var backItems = BackSeedData.GetItems();
                context.GearItems.AddRange(backItems);



                var subItems = GripSeedData.GetItems();
                context.GearItems.AddRange(subItems);

                var rangeItems = RangeSeedData.GetItems();
                context.GearItems.AddRange(rangeItems);

                context.SaveChanges();
            }
        }
    }
}
