namespace Portfolio.Domain.Entities.Education;

public class EducationLink
{
    public int Id { get; set; }
    public string Label { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;

    public int EducationId { get; set; }
    public Education Education { get; set; } = null!;
}
