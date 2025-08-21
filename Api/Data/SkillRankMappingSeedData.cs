using GearForgeXI.Models;
using System.Globalization;
using System.Reflection;

namespace GearForgeXI.Data;

/// <summary>
/// Provides seed data for skill rank mappings loaded from CSV
/// </summary>
public static class SkillRankMappingSeedData
{
    /// <summary>
    /// Gets all skill rank mapping data for seeding the database
    /// </summary>
    public static SkillRankMapping[] GetSeedData()
    {
        return LoadFromCsv();
    }

    /// <summary>
    /// Loads skill rank mappings from embedded CSV resource
    /// </summary>
    private static SkillRankMapping[] LoadFromCsv()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceName = "GearForgeXI.Data.SkillRankMappings.csv";

        using var stream = assembly.GetManifestResourceStream(resourceName);
        if (stream == null)
        {
            throw new InvalidOperationException($"Could not find embedded resource: {resourceName}");
        }

        using var reader = new StreamReader(stream);
        var mappings = new List<SkillRankMapping>();
        var id = 1;

        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            var parts = line.Split(',');
            if (parts.Length != 100) // 1 skill rank + 99 skill values (levels 1-99)
            {
                throw new InvalidOperationException($"Invalid CSV line format. Expected 100 columns (rank + 99 levels), got {parts.Length}: {line}");
            }

            var skillRankString = parts[0].Trim();
            var skillRank = ParseSkillRank(skillRankString);

            // Process each level (columns 1-99 represent levels 1-99)
            for (int level = 1; level <= 99; level++)
            {
                var skillValue = int.Parse(parts[level].Trim());

                mappings.Add(new SkillRankMapping
                {
                    Id = id++,
                    SkillRank = skillRank,
                    Level = level,
                    SkillValue = skillValue
                });
            }
        }

        return mappings.ToArray();
    }    /// <summary>
         /// Converts skill rank string to enum value
         /// </summary>
    private static SkillRank ParseSkillRank(string rankString)
    {
        return rankString.ToUpper() switch
        {
            "A+" => SkillRank.APlus,
            "A-" => SkillRank.AMinus,
            "B+" => SkillRank.BPlus,
            "B" => SkillRank.B,
            "B-" => SkillRank.BMinus,
            "C+" => SkillRank.CPlus,
            "C" => SkillRank.C,
            "C-" => SkillRank.CMinus,
            "D" => SkillRank.D,
            "E" => SkillRank.E,
            "F" => SkillRank.F,
            _ => throw new ArgumentException($"Unknown skill rank: {rankString}")
        };
    }
}
