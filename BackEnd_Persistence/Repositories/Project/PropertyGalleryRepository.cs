using Application.Contract.Persistance.EntitiesRepository.Project;
using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Persistence.Repositories.Project
{
    public class PropertyGalleryRepository : GenericRepository<PropertyGallery>, IPropertyGalleryRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public PropertyGalleryRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<PropertyGallery>> GetPropertyGalleryList(long propertyId)
        {
            return await _dbContext.PropertyGalleries.Where(x => x.PropertyId == propertyId).ToListAsync();
        }
    }
}
