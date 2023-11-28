using CloudResume.Application.Visitors;
using Microsoft.Extensions.DependencyInjection;

namespace CloudResume.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IVisitorsService, VisitorsService>();
        return services;
    }
}