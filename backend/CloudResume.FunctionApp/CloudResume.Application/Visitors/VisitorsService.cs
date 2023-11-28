using CloudResume.Domain.Visitors;

namespace CloudResume.Application.Visitors;

public class VisitorsService : IVisitorsService
{
    private readonly IVisitorsRepository _visitorsRepository;

    public VisitorsService(IVisitorsRepository visitorsRepository)
    {
        _visitorsRepository = visitorsRepository;
    }

    public Task<IEnumerable<Visitor>> GetAllVisitors()
    {
        return _visitorsRepository.GetAllVisitors();
    }
}