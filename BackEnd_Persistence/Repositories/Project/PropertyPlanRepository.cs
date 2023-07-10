using Application.Contract.Persistence.EntitiesRepository.Project;
using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Persistence.Repositories.Project
{
    public class PropertyPlanRepository : GenericRepository<PropertyPlan>, IPropertyPlanRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public PropertyPlanRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<PropertyPlan>> GetListOfPlanOfProperty(long propertyId)
        {
            return await _dbContext.PropertyPlans.Where(x => x.PropertyId == propertyId).ToListAsync();
        }
    }
}
