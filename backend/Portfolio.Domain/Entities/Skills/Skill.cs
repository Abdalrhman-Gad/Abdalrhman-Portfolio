namespace Portfolio.Domain.Entities.Skills;

public class Skill
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int SkillGroupId { get; set; }
    public SkillGroup SkillGroup { get; set; } = null!;
}
