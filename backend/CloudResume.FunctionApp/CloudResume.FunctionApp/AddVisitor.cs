using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace CloudResume.FunctionApp;

public static class AddVisitor
{
    [FunctionName("AddVisitor")]
    public static async Task<IActionResult> RunAsync([HttpTrigger(AuthorizationLevel.Function, "put", Route = "visitors")] HttpRequest req, ILogger log)
    {
        return new OkObjectResult($"Add visitor");
    }
}