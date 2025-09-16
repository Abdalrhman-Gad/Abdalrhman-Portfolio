namespace Portfolio.Api.Models;

public class SkillGroup
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;

    public int ProfileId { get; set; }
    public Profile Profile { get; set; } = null!;

    public ICollection<Skill> Skills { get; set; } = new List<Skill>();
}

public class Skill
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int SkillGroupId { get; set; }
    public SkillGroup SkillGroup { get; set; } = null!;
}
