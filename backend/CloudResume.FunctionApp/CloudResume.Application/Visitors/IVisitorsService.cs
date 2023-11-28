using CloudResume.Domain;
using CloudResume.Domain.Visitors;

namespace CloudResume.Application.Visitors;

public interface IVisitorsService
{
    Task<IEnumerable<Visitor>> GetAllVisitors();
}