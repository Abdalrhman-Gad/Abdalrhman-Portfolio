namespace Portfolio.Domain.Entities.Experience;

public class ExperienceBullet
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;

    public int ExperienceId { get; set; }
    public Experience Experience { get; set; } = null!;
}
