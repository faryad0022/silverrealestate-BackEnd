using Application.Contract.Persistence.CommonGenericRepository;
using Domain.Entities.Project;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contract.Persistance.EntitiesRepository.Project
{
    public interface IPropertyGalleryRepository : IGenericRepository<PropertyGallery>
    {
        Task<List<PropertyGallery>> GetPropertyGalleryList(long propertyId);
    }
}
