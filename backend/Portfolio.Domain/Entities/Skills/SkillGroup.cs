namespace Portfolio.Domain.Entities.Skills;

using Portfolio.Domain.Entities.ProfileAggregate;

public class SkillGroup
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;

    public int ProfileId { get; set; }
    public Profile Profile { get; set; } = null!;

    public ICollection<Skill> Skills { get; set; } = new List<Skill>();
}
