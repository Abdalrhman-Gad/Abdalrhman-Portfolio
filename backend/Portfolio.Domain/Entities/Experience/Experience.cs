namespace Portfolio.Domain.Entities.Experience;

using Portfolio.Domain.Entities.ProfileAggregate;

public class Experience
{
    public int Id { get; set; }
    public string Role { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string Period { get; set; } = string.Empty;
    public string? Description { get; set; }

    public int ProfileId { get; set; }
    public Profile Profile { get; set; } = null!;

    public ICollection<ExperienceBullet> Bullets { get; set; } = new List<ExperienceBullet>();
    public ICollection<ExperienceTech> Tech { get; set; } = new List<ExperienceTech>();
}
