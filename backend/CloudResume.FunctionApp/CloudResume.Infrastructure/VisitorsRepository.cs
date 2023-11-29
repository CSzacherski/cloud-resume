using Azure.Data.Tables;
using CloudResume.Domain.Visitors;

namespace CloudResume.Infrastructure;

public class VisitorsRepository : IVisitorsRepository
{
    private readonly TableServiceClient _tableServiceClient;
    private readonly TableClient _visitorsTableClient;

    public VisitorsRepository()
    {
        _tableServiceClient = new TableServiceClient(Environment.GetEnvironmentVariable("COSMOS_CONNECTION_STRING"));
        _visitorsTableClient = _tableServiceClient.GetTableClient(
            tableName: "Visitors"
        );
    }

    public async Task<int> GetVisitorsCount()
    {
        var pageable = _visitorsTableClient.QueryAsync<Visitor>(x => x.PartitionKey == "visitor");
        var list = await pageable.ToListAsync();
        return list.Count;
    }

    public void AddVisitor()
    {
        var visitor = new Visitor { PartitionKey = "visitor", RowKey = Guid.NewGuid().ToString(), Timestamp = DateTimeOffset.Now };
        _visitorsTableClient.AddEntityAsync(visitor);
    }
}