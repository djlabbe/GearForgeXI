namespace GearForgeXI.Models.Dto;

public class CharacterProfileDto
{
    public int Id { get; set; }
    public string CharacterName { get; set; } = null!;
    public string Server { get; set; } = null!;
    public string Race { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public List<CharacterJobDto> CharacterJobs { get; set; } = new();
}

public class CreateCharacterProfileDto
{
    public string CharacterName { get; set; } = null!;
    public int Server { get; set; }
    public int Race { get; set; }
}

public class UpdateCharacterProfileDto
{
    public string? CharacterName { get; set; }
    public int? Server { get; set; }
    public int? Race { get; set; }
}

public class CharacterJobDto
{
    public int Id { get; set; }
    public JobDto Job { get; set; } = null!;
    public int JobLevel { get; set; }
    public int MasterLevel { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public class UpdateCharacterJobDto
{
    public int JobId { get; set; }
    public int JobLevel { get; set; }
    public int MasterLevel { get; set; }
}
