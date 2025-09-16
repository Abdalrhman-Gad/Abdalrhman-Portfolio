namespace Portfolio.Api.Models;

public class Profile
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Availability { get; set; } = string.Empty;
    public string Military { get; set; } = string.Empty;

    public ICollection<Link> Links { get; set; } = new List<Link>();
    public ICollection<SkillGroup> SkillGroups { get; set; } = new List<SkillGroup>();
    public ICollection<Project> Projects { get; set; } = new List<Project>();
    public ICollection<Experience> Experiences { get; set; } = new List<Experience>();
    public ICollection<Education> Education { get; set; } = new List<Education>();
    public ICollection<Language> Languages { get; set; } = new List<Language>();
    public ICollection<SoftSkill> SoftSkills { get; set; } = new List<SoftSkill>();
    public ICollection<Interest> Interests { get; set; } = new List<Interest>();
}

public class Link
{
    public int Id { get; set; }
    public string Label { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string? Icon { get; set; }

    public int ProfileId { get; set; }
    public Profile Profile { get; set; } = null!;
}

public class Language
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int ProfileId { get; set; }
    public Profile Profile { get; set; } = null!;
}

public class SoftSkill
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int ProfileId { get; set; }
    public Profile Profile { get; set; } = null!;
}

public class Interest
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int ProfileId { get; set; }
    public Profile Profile { get; set; } = null!;
}
