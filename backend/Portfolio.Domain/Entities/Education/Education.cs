namespace Portfolio.Domain.Entities.Education;

using Portfolio.Domain.Entities.ProfileAggregate;

public class Education
{
    public int Id { get; set; }
    public string Degree { get; set; } = string.Empty;
    public string School { get; set; } = string.Empty;
    public string Period { get; set; } = string.Empty;
    public string? Gpa { get; set; }
    public string? Honor { get; set; }

    public int ProfileId { get; set; }
    public Profile Profile { get; set; } = null!;

    public ICollection<EducationDetail> Details { get; set; } = new List<EducationDetail>();
    public ICollection<EducationLink> Links { get; set; } = new List<EducationLink>();
}
