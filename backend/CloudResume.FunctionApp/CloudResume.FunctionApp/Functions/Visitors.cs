using System.Linq;
using System.Threading.Tasks;
using CloudResume.Application.Visitors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace CloudResume.FunctionApp.Functions;

public class Visitors
{
    private readonly IVisitorsService _visitorsService;

    public Visitors(IVisitorsService visitorsService)
    {
        _visitorsService = visitorsService;
    }

    [FunctionName("GetVisitorsTrigger")]
    public async Task<IActionResult> GetVisitorsTriggerAsync([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "visitors")] HttpRequest req, ILogger log)
    {
        log.LogInformation($"C# HTTP trigger function stared a request. {nameof(GetVisitorsTriggerAsync)}");
        var cnt = await _visitorsService.GetVisitorsCount();
        return new OkObjectResult($"{cnt}");
    }
    
    [FunctionName("AddVisitorTrigger")]
    public async Task<IActionResult> AddVisitorTriggerAsync([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "visitors")] HttpRequest req, ILogger log)
    {
        log.LogInformation($"C# HTTP trigger function stared a request. {nameof(AddVisitorTriggerAsync)}");
        _visitorsService.AddVisitor();
        return new OkObjectResult("Ok");
    }
}