
using CloudResume.Domain.Visitors;
using Microsoft.Extensions.DependencyInjection;

namespace CloudResume.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IVisitorsRepository, VisitorsRepository>();
        return services;
    }
}