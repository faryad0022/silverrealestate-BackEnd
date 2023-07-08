using Application.Contract.Persistence.CommonGenericRepository;
using Application.Models.FilterModels;
using Domain.Entities.Project;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contract.Persistance.EntitiesRepository.Project
{
    public interface IPropertyRepository : IGenericRepository<Property>
    {
        Task<FilterProperty> FilterProperty(FilterProperty filter);
        Task<List<Property>> GetPropertyListWithDetails();
        Task<Property> GetPropertyWithDetails(long id);

    }
}
