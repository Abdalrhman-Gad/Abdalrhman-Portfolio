using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Api.Data;
using Portfolio.Api.Dtos;

namespace Portfolio.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProfileController : ControllerBase
{
    private readonly PortfolioContext _context;

    public ProfileController(PortfolioContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<ProfileDto>> Get()
    {
        var profile = await _context.Profiles
            .Include(p => p.Links)
            .Include(p => p.SkillGroups).ThenInclude(g => g.Skills)
            .Include(p => p.Projects).ThenInclude(p => p.Tech)
            .Include(p => p.Experiences).ThenInclude(e => e.Bullets)
            .Include(p => p.Experiences).ThenInclude(e => e.Tech)
            .Include(p => p.Education).ThenInclude(e => e.Details)
            .Include(p => p.Education).ThenInclude(e => e.Links)
            .Include(p => p.Languages)
            .Include(p => p.SoftSkills)
            .Include(p => p.Interests)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (profile is null)
        {
            return NotFound();
        }

        var dto = new ProfileDto(
            profile.Name,
            profile.Title,
            profile.Summary,
            profile.Location,
            profile.Email,
            profile.Phone,
            profile.Availability,
            profile.Military,
            profile.Links
                .OrderBy(l => l.Id)
                .Select(l => new LinkDto(l.Label, l.Url, l.Icon))
                .ToList(),
            profile.SkillGroups
                .OrderBy(g => g.Id)
                .Select(g => new SkillGroupDto(g.Title, g.Skills.OrderBy(s => s.Id).Select(s => s.Name).ToList()))
                .ToList(),
            profile.Projects
                .OrderBy(p => p.Id)
                .Select(p => new ProjectDto(p.Name, p.Description, p.Tech.OrderBy(t => t.Id).Select(t => t.Name).ToList(), p.Url))
                .ToList(),
            profile.Experiences
                .OrderBy(e => e.Id)
                .Select(e => new ExperienceDto(
                    e.Role,
                    e.Company,
                    e.Period,
                    e.Description,
                    e.Bullets.OrderBy(b => b.Id).Select(b => b.Text).ToList(),
                    e.Tech.OrderBy(t => t.Id).Select(t => t.Name).ToList()))
                .ToList(),
            profile.Education
                .OrderBy(e => e.Id)
                .Select(e => new EducationDto(
                    e.Degree,
                    e.School,
                    e.Period,
                    e.Gpa,
                    e.Honor,
                    e.Details.OrderBy(d => d.Id).Select(d => d.Text).ToList(),
                    e.Links.OrderBy(l => l.Id).Select(l => new EducationLinkDto(l.Label, l.Url)).ToList()))
                .ToList(),
            profile.Languages.OrderBy(l => l.Id).Select(l => l.Name).ToList(),
            profile.SoftSkills.OrderBy(s => s.Id).Select(s => s.Name).ToList(),
            profile.Interests.OrderBy(i => i.Id).Select(i => i.Name).ToList());

        return dto;
    }
}
