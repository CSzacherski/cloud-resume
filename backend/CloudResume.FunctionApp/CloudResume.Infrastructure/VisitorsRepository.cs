using CloudResume.Domain.Visitors;

namespace CloudResume.Infrastructure;

public class VisitorsRepository : IVisitorsRepository
{
    public Task<IEnumerable<Visitor>> GetAllVisitors()
    {
        var visitor = new Visitor(Guid.NewGuid());
        return Task.FromResult(new[] { visitor }.AsEnumerable());
    }
}