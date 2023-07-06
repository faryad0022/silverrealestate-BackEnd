using Application.Contract.Persistence.EntitiesRepository.Project;
using Domain.Entities.Project;

namespace BackEnd_Persistence.Repositories.Project
{
    public class PropertyContractTypeRepository : GenericRepository<PropertyContractType>, IPropertyContractTypeRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public PropertyContractTypeRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
