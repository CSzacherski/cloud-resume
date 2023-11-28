using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using CloudResume.Application;
using CloudResume.Infrastructure;

[assembly: FunctionsStartup(typeof(CloudResume.FunctionApp.Startup))]

namespace CloudResume.FunctionApp;

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services.AddApplication().AddInfrastructure();
    }
}