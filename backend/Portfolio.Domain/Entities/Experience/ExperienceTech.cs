namespace Portfolio.Domain.Entities.Experience;

public class ExperienceTech
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int ExperienceId { get; set; }
    public Experience Experience { get; set; } = null!;
}
