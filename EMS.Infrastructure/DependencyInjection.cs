using EMS.Infrastructure.Repositories;
using EMS.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EMS.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureService(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}