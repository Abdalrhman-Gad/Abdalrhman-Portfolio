namespace Portfolio.Infrastructure.Profiles;

using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Profiles.Dtos;
using Portfolio.Application.Profiles.Mappings;
using Portfolio.Application.Profiles.Services;
using Portfolio.Infrastructure.Data;

public sealed class ProfileReadService : IProfileReadService
{
    private readonly PortfolioDbContext _dbContext;

    public ProfileReadService(PortfolioDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ProfileDto?> GetProfileAsync(CancellationToken cancellationToken = default)
    {
        var profile = await _dbContext.Profiles
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
            .FirstOrDefaultAsync(cancellationToken);

        return profile is null ? null : ProfileMapper.ToDto(profile);
    }
}
