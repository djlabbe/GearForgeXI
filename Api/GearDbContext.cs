
using Microsoft.EntityFrameworkCore;
using GearForgeXI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GearForgeXI
{
    public class GearDbContext : IdentityDbContext<ApplicationUser>
    {
        public GearDbContext(DbContextOptions<GearDbContext> options) : base(options) { }
        public DbSet<GearItem> GearItems { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<GearSlot> GearSlots { get; set; }
        public DbSet<GearItemCategory> GearItemCategories { get; set; }
        public DbSet<GearItemJob> GearItemJobs { get; set; }
        public DbSet<GearItemSlot> GearItemSlots { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<GearItemStat> GearItemStats { get; set; }
        public DbSet<GearSet> GearSets { get; set; } = null!;
        public DbSet<GearSetItem> GearSetItems { get; set; } = null!;
        public DbSet<RefreshToken> RefreshTokens { get; set; } = null!;
        public DbSet<CharacterProfile> CharacterProfiles { get; set; } = null!;
        public DbSet<CharacterJob> CharacterJobs { get; set; } = null!;



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

            // GearItem -> GearItemJob (1:M)
            modelBuilder.Entity<GearItemJob>()
                .HasOne(gij => gij.GearItem)
                .WithMany(gi => gi.GearItemJobs)
                .HasForeignKey(gij => gij.GearItemId);

            modelBuilder.Entity<GearItemJob>()
                .HasOne(gij => gij.Job)
                .WithMany(j => j.GearItemJobs)
                .HasForeignKey(gij => gij.JobId);

            // GearItem -> GearItemSlot (1:M)
            modelBuilder.Entity<GearItemSlot>()
                .HasOne(gis => gis.GearItem)
                .WithMany(gi => gi.GearItemSlots)
                .HasForeignKey(gis => gis.GearItemId);

            modelBuilder.Entity<GearItemSlot>()
                .HasOne(gis => gis.GearSlot)
                .WithMany(gs => gs.GearItemSlots)
                .HasForeignKey(gis => gis.GearSlotId);

            // GearItem -> GearItemStat (1:M)
            modelBuilder.Entity<GearItemStat>()
                .HasOne(gis => gis.GearItem)
                .WithMany(gi => gi.GearItemStats)
                .HasForeignKey(gis => gis.GearItemId);

            modelBuilder.Entity<GearItemStat>()
                .HasOne(gis => gis.Stat)
                .WithMany(s => s.GearItemStats)
                .HasForeignKey(gis => gis.StatId);

            // Optional: Unique constraint on Stat.Name
            modelBuilder.Entity<Stat>()
                .HasIndex(s => s.Name)
                .IsUnique();

            // Add performance indexes for frequently queried columns
            modelBuilder.Entity<GearItem>()
                .HasIndex(g => g.Name);

            modelBuilder.Entity<GearItem>()
                .HasIndex(g => g.Verified);

            modelBuilder.Entity<Job>()
                .HasIndex(j => j.Abbreviation);

            modelBuilder.Entity<GearSlot>()
                .HasIndex(gs => gs.Name);

            modelBuilder.Entity<GearSet>()
                .HasIndex(gs => gs.UserId);

            // Composite indexes for common query patterns
            modelBuilder.Entity<GearItemJob>()
                .HasIndex(gij => new { gij.GearItemId, gij.JobId });

            modelBuilder.Entity<GearItemSlot>()
                .HasIndex(gis => new { gis.GearItemId, gis.GearSlotId });

            modelBuilder.Entity<GearSetItem>()
                .HasIndex(gsi => new { gsi.GearSetId, gsi.Position });

            // Store Stat.Category as string
            modelBuilder.Entity<Stat>()
                .Property(s => s.Category)
                .HasConversion<string>();

            // GearSetItem: many-to-one with GearSet
            modelBuilder.Entity<GearSetItem>()
                .HasOne(gss => gss.GearSet)
                .WithMany(gs => gs.GearSetItems)
                .HasForeignKey(gss => gss.GearSetId);

            // GearSetItem: many-to-one with GearItem
            modelBuilder.Entity<GearSetItem>()
                .HasOne(gss => gss.GearItem)
                .WithMany()  // No backref needed
                .HasForeignKey(gss => gss.GearItemId);

            // Store GearSetItem.Position as string
            modelBuilder.Entity<GearSetItem>()
                .Property(gss => gss.Position)
                .HasConversion<string>();

            // Optional: Unique constraints for GearItemJob and GearItemSlot
            modelBuilder.Entity<GearItemSlot>()
                .HasIndex(gis => new { gis.GearItemId, gis.GearSlotId })
                .IsUnique();

            modelBuilder.Entity<GearItemJob>()
                .HasIndex(gij => new { gij.GearItemId, gij.JobId })
                .IsUnique();

            modelBuilder.Entity<GearSetItem>()
                .HasIndex(gss => new { gss.GearSetId, gss.Position })
                .IsUnique();

            // GearSet: many-to-one with User
            modelBuilder.Entity<GearSet>()
                .HasOne(gs => gs.User)
                .WithMany(u => u.GearSets)  // Now we have the navigation property
                .HasForeignKey(gs => gs.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Delete user's gear sets when user is deleted

            // GearSet: many-to-one with Job
            modelBuilder.Entity<GearSet>()
                .HasOne(gs => gs.Job)
                .WithMany()
                .HasForeignKey(gs => gs.JobId)
                .OnDelete(DeleteBehavior.Restrict); // Don't allow job deletion if gear sets exist

            // CharacterProfile relationships
            modelBuilder.Entity<CharacterProfile>()
                .HasOne(cp => cp.User)
                .WithMany(u => u.CharacterProfiles)
                .HasForeignKey(cp => cp.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // CharacterJob relationships
            modelBuilder.Entity<CharacterJob>()
                .HasOne(cj => cj.CharacterProfile)
                .WithMany(cp => cp.CharacterJobs)
                .HasForeignKey(cj => cj.CharacterProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CharacterJob>()
                .HasOne(cj => cj.Job)
                .WithMany()
                .HasForeignKey(cj => cj.JobId)
                .OnDelete(DeleteBehavior.Restrict);

            // Character profile indexes for performance
            modelBuilder.Entity<CharacterProfile>()
                .HasIndex(cp => cp.UserId);

            modelBuilder.Entity<CharacterProfile>()
                .HasIndex(cp => new { cp.CharacterName, cp.Server })
                .IsUnique(); // Prevent duplicate character names on same server

            modelBuilder.Entity<CharacterJob>()
                .HasIndex(cj => new { cj.CharacterProfileId, cj.JobId })
                .IsUnique(); // One character job record per job per character

            // Convert enums to string for database storage
            modelBuilder.Entity<CharacterProfile>()
                .Property(cp => cp.Race)
                .HasConversion<string>();

            modelBuilder.Entity<CharacterProfile>()
                .Property(cp => cp.Server)
                .HasConversion<string>();

        }
    }
}
