namespace GearForgeXI.Models;

public class JobTrait
{
    public string Name { get; set; } = null!;
    public int Level { get; set; }
    /// <summary>
    /// Dictionary mapping Stat ID to modifier value
    /// </summary>
    public Dictionary<int, int> StatModifiers { get; set; } = new();
}
