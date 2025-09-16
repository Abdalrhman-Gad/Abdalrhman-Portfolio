namespace Portfolio.Domain.Entities.Education;

public class EducationDetail
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;

    public int EducationId { get; set; }
    public Education Education { get; set; } = null!;
}
