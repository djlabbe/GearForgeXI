namespace GearForgeXI.Models;

/// <summary>
/// Represents a character's complete statistics using database Stat entities
/// </summary>
public class CharacterStatistics
{
    /// <summary>
    /// Dictionary mapping Stat ID to the total calculated value for that stat
    /// </summary>
    public Dictionary<int, int> StatValues { get; set; } = new();

    /// <summary>
    /// Dictionary mapping Stat ID to list of modifiers that contributed to that stat
    /// </summary>
    public Dictionary<int, List<StatModifier>> StatModifiers { get; set; } = new();

    /// <summary>
    /// List of active trait names (for display purposes)
    /// </summary>
    public List<string> ActiveTraits { get; set; } = new();

    /// <summary>
    /// Add a stat modifier to the character's statistics
    /// </summary>
    public void AddModifier(int statId, int value, string source)
    {
        // Add to modifiers tracking
        if (!StatModifiers.ContainsKey(statId))
        {
            StatModifiers[statId] = new List<StatModifier>();
        }

        StatModifiers[statId].Add(new StatModifier
        {
            Value = value,
            Source = source
        });

        // Add to total values
        if (!StatValues.ContainsKey(statId))
        {
            StatValues[statId] = 0;
        }

        StatValues[statId] += value;
    }

    /// <summary>
    /// Get the total value for a specific stat
    /// </summary>
    public int GetStatValue(int statId)
    {
        return StatValues.TryGetValue(statId, out var value) ? value : 0;
    }

    /// <summary>
    /// Get all modifiers for a specific stat
    /// </summary>
    public List<StatModifier> GetStatModifiers(int statId)
    {
        return StatModifiers.TryGetValue(statId, out var modifiers) ? modifiers : new List<StatModifier>();
    }

    /// <summary>
    /// Check if the character has any value for a specific stat
    /// </summary>
    public bool HasStat(int statId)
    {
        return StatValues.ContainsKey(statId) && StatValues[statId] != 0;
    }
}
