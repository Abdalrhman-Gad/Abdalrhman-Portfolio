namespace Portfolio.Infrastructure;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Application.Common.Interfaces;
using Portfolio.Application.Profiles.Services;
using Portfolio.Infrastructure.Data;
using Portfolio.Infrastructure.Profiles;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Portfolio")
            ?? throw new InvalidOperationException("Connection string 'Portfolio' was not found.");

        services.AddDbContext<PortfolioDbContext>(options => options.UseSqlite(connectionString));

        services.AddScoped<IDatabaseSeeder, DataSeeder>();
        services.AddScoped<IProfileReadService, ProfileReadService>();

        return services;
    }
}
