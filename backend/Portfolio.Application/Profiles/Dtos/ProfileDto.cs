namespace Portfolio.Application.Profiles.Dtos;

public sealed record LinkDto(string Label, string Url, string? Icon);

public sealed record SkillGroupDto(string Title, IReadOnlyCollection<string> Items);

public sealed record ProjectDto(string Name, string Description, IReadOnlyCollection<string> Tech, string? Url);

public sealed record ExperienceDto(
    string Role,
    string Company,
    string Period,
    string? Description,
    IReadOnlyCollection<string> Bullets,
    IReadOnlyCollection<string> Tech);

public sealed record EducationLinkDto(string Label, string Url);

public sealed record EducationDto(
    string Degree,
    string School,
    string Period,
    string? Gpa,
    string? Honor,
    IReadOnlyCollection<string> Details,
    IReadOnlyCollection<EducationLinkDto> Links);

public sealed record ProfileDto(
    string Name,
    string Title,
    string Summary,
    string Location,
    string Email,
    string Phone,
    string Availability,
    string Military,
    IReadOnlyCollection<LinkDto> Links,
    IReadOnlyCollection<SkillGroupDto> SkillGroups,
    IReadOnlyCollection<ProjectDto> Projects,
    IReadOnlyCollection<ExperienceDto> Experiences,
    IReadOnlyCollection<EducationDto> Education,
    IReadOnlyCollection<string> Languages,
    IReadOnlyCollection<string> SoftSkills,
    IReadOnlyCollection<string> Interests);
