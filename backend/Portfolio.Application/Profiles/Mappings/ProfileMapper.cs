namespace Portfolio.Application.Profiles.Mappings;

using Portfolio.Application.Profiles.Dtos;
using Portfolio.Domain.Entities.Education;
using Portfolio.Domain.Entities.Experience;
using Portfolio.Domain.Entities.ProfileAggregate;
using Portfolio.Domain.Entities.Projects;
using Portfolio.Domain.Entities.Skills;

public static class ProfileMapper
{
    public static ProfileDto ToDto(Profile profile)
    {
        ArgumentNullException.ThrowIfNull(profile);

        return new ProfileDto(
            profile.Name,
            profile.Title,
            profile.Summary,
            profile.Location,
            profile.Email,
            profile.Phone,
            profile.Availability,
            profile.Military,
            MapLinks(profile.Links),
            MapSkillGroups(profile.SkillGroups),
            MapProjects(profile.Projects),
            MapExperiences(profile.Experiences),
            MapEducation(profile.Education),
            profile.Languages.OrderBy(language => language.Id).Select(language => language.Name).ToList(),
            profile.SoftSkills.OrderBy(skill => skill.Id).Select(skill => skill.Name).ToList(),
            profile.Interests.OrderBy(interest => interest.Id).Select(interest => interest.Name).ToList());
    }

    private static IReadOnlyCollection<LinkDto> MapLinks(IEnumerable<Link> links) =>
        links
            .OrderBy(link => link.Id)
            .Select(link => new LinkDto(link.Label, link.Url, link.Icon))
            .ToList();

    private static IReadOnlyCollection<SkillGroupDto> MapSkillGroups(IEnumerable<SkillGroup> groups) =>
        groups
            .OrderBy(group => group.Id)
            .Select(group => new SkillGroupDto(
                group.Title,
                group.Skills
                    .OrderBy(skill => skill.Id)
                    .Select(skill => skill.Name)
                    .ToList()))
            .ToList();

    private static IReadOnlyCollection<ProjectDto> MapProjects(IEnumerable<Project> projects) =>
        projects
            .OrderBy(project => project.Id)
            .Select(project => new ProjectDto(
                project.Name,
                project.Description,
                project.Tech
                    .OrderBy(tech => tech.Id)
                    .Select(tech => tech.Name)
                    .ToList(),
                project.Url))
            .ToList();

    private static IReadOnlyCollection<ExperienceDto> MapExperiences(IEnumerable<Experience> experiences) =>
        experiences
            .OrderBy(experience => experience.Id)
            .Select(experience => new ExperienceDto(
                experience.Role,
                experience.Company,
                experience.Period,
                experience.Description,
                experience.Bullets
                    .OrderBy(bullet => bullet.Id)
                    .Select(bullet => bullet.Text)
                    .ToList(),
                experience.Tech
                    .OrderBy(tech => tech.Id)
                    .Select(tech => tech.Name)
                    .ToList()))
            .ToList();

    private static IReadOnlyCollection<EducationDto> MapEducation(IEnumerable<Education> educationItems) =>
        educationItems
            .OrderBy(item => item.Id)
            .Select(item => new EducationDto(
                item.Degree,
                item.School,
                item.Period,
                item.Gpa,
                item.Honor,
                item.Details
                    .OrderBy(detail => detail.Id)
                    .Select(detail => detail.Text)
                    .ToList(),
                item.Links
                    .OrderBy(link => link.Id)
                    .Select(link => new EducationLinkDto(link.Label, link.Url))
                    .ToList()))
            .ToList();
}
