namespace CloudResume.Domain.Visitors;

public interface IVisitorsRepository
{
    public Task<int> GetVisitorsCount();
}