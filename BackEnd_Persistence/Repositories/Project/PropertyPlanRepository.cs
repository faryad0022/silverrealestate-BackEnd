using Application.Contract.Persistence.EntitiesRepository.Project;
using Domain.Entities.Project;

namespace BackEnd_Persistence.Repositories.Project
{
    public class PropertyPlanRepository : GenericRepository<PropertyPlan>, IPropertyPlanRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public PropertyPlanRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
