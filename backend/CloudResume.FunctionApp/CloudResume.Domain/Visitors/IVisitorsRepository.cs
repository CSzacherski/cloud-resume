namespace CloudResume.Domain.Visitors;

public interface IVisitorsRepository
{
    public Task<IEnumerable<Visitor>> GetAllVisitors();
}