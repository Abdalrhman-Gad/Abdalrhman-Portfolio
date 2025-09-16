namespace Portfolio.Api.Models;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? Url { get; set; }

    public int ProfileId { get; set; }
    public Profile Profile { get; set; } = null!;

    public ICollection<ProjectTech> Tech { get; set; } = new List<ProjectTech>();
}

public class ProjectTech
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int ProjectId { get; set; }
    public Project Project { get; set; } = null!;
}
