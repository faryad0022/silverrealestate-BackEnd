using Application.Contract.Persistance.EntitiesRepository.Project;
using Domain.Entities.Project;

namespace BackEnd_Persistence.Repositories.Project
{
    public class PropertyTypeRepository : GenericRepository<PropertyType>, IPropertyTypeRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public PropertyTypeRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
