using Application.Contract.Persistence.CommonGenericRepository;
using Domain.Entities.Project;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contract.Persistance.EntitiesRepository.Project
{
    public interface IPropertyVideoRepository : IGenericRepository<PropertyVideo>
    {
        Task<List<PropertyVideo>> GetListVideoOfProperty(long propertyId);
    }
}
