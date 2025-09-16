namespace Portfolio.Domain.Entities.Projects;

public class ProjectTech
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int ProjectId { get; set; }
    public Project Project { get; set; } = null!;
}
