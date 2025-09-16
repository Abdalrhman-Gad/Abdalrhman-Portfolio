using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Profiles.Dtos;
using Portfolio.Application.Profiles.Services;

namespace Portfolio.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProfileController : ControllerBase
{
    private readonly IProfileReadService _profileReadService;

    public ProfileController(IProfileReadService profileReadService)
    {
        _profileReadService = profileReadService;
    }

    [HttpGet]
    public async Task<ActionResult<ProfileDto>> Get(CancellationToken cancellationToken)
    {
        var profile = await _profileReadService.GetProfileAsync(cancellationToken);

        return profile is null ? NotFound() : Ok(profile);
    }
}
