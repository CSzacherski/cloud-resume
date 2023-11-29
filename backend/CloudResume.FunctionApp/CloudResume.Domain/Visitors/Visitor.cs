using Azure;
using Azure.Data.Tables;

namespace CloudResume.Domain.Visitors;

public sealed record Visitor : ITableEntity
{
    public string RowKey { get; set; } = default!;
    public string PartitionKey { get; set; } = default!;
    public ETag ETag { get; set; } = default!;
    public DateTimeOffset? Timestamp { get; set; } = default!;
}