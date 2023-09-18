using Application.Contract.Persistance.EntitiesRepository.Project;
using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Persistence.Repositories.Project
{
    public class PropertyVideoRepository : GenericRepository<PropertyVideo>, IPropertyVideoRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public PropertyVideoRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<PropertyVideo>> GetListVideoOfProperty(long propertyId)
        {
            return await _dbContext.PropertyVideos.Where(x => x.PropertyId == propertyId).ToListAsync();
        }
    }
}
