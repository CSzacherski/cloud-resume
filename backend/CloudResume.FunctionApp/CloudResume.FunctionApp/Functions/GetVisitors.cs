using System.Linq;
using System.Threading.Tasks;
using CloudResume.Application.Visitors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace CloudResume.FunctionApp.Functions;

public class GetVisitors
{
    private readonly IVisitorsService _visitorsService;

    public GetVisitors(IVisitorsService visitorsService)
    {
        _visitorsService = visitorsService;
    }

    [FunctionName("GetVisitorsTrigger")]
    public async Task<IActionResult> RunAsync([HttpTrigger(AuthorizationLevel.Function, "get", Route = "visitors")] HttpRequest req, ILogger log)
    {
        log.LogInformation("C# HTTP trigger function processed a request.");
        var cnt = await _visitorsService.GetVisitorsCount();
        return new OkObjectResult($"{cnt}");
    }
}