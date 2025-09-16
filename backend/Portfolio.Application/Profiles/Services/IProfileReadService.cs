namespace Portfolio.Application.Profiles.Services;

using Portfolio.Application.Profiles.Dtos;

public interface IProfileReadService
{
    Task<ProfileDto?> GetProfileAsync(CancellationToken cancellationToken = default);
}
