using Azure.Data.Tables;
using CloudResume.Domain.Visitors;

namespace CloudResume.Infrastructure;

public class VisitorsRepository : IVisitorsRepository
{
    public async Task<int> GetVisitorsCount()
    {
        var tableServiceClient = new TableServiceClient(Environment.GetEnvironmentVariable("COSMOS_CONNECTION_STRING"));
        var tableClient = tableServiceClient.GetTableClient(
            tableName: "Visitors"
        );
        var visitorsCount = await tableClient.GetEntityIfExistsAsync<Visitor>("count", "count");
        return visitorsCount?.Value?.Count ?? 0;
    }
}