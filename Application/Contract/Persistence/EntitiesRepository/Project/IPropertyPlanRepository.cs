using Application.Contract.Persistence.CommonGenericRepository;
using Domain.Entities.Project;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contract.Persistence.EntitiesRepository.Project
{
    public interface IPropertyPlanRepository : IGenericRepository<PropertyPlan>
    {
        Task<List<PropertyPlan>> GetListOfPlanOfProperty(long propertyId);
    }
}
