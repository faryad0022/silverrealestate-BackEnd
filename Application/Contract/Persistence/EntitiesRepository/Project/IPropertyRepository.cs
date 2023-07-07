using Application.Contract.Persistence.CommonGenericRepository;
using Domain.Entities.Project;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contract.Persistance.EntitiesRepository.Project
{
    public interface IPropertyRepository : IGenericRepository<Property>
    {
        Task<List<Property>> GetPropertyListAsync(string PropertyType, string City, long PropertyStatusId);
    }
}
