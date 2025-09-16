namespace Portfolio.Domain.Entities.ProfileAggregate;

using Portfolio.Domain.Entities.Education;
using Portfolio.Domain.Entities.Experience;
using Portfolio.Domain.Entities.Projects;
using Portfolio.Domain.Entities.Skills;

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
