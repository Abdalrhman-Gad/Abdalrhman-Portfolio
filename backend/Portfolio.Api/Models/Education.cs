namespace Portfolio.Api.Models;

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

public class EducationDetail
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;

    public int EducationId { get; set; }
    public Education Education { get; set; } = null!;
}

public class EducationLink
{
    public int Id { get; set; }
    public string Label { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;

    public int EducationId { get; set; }
    public Education Education { get; set; } = null!;
}
