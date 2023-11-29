using CloudResume.Domain.Visitors;

namespace CloudResume.Application.Visitors;

public class VisitorsService : IVisitorsService
{
    private readonly IVisitorsRepository _visitorsRepository;

    public VisitorsService(IVisitorsRepository visitorsRepository)
    {
        _visitorsRepository = visitorsRepository;
    }

    public Task<int> GetVisitorsCount()
    {
        return _visitorsRepository.GetVisitorsCount();
    }

    public void AddVisitor()
    {
        _visitorsRepository.AddVisitor();
    }
}