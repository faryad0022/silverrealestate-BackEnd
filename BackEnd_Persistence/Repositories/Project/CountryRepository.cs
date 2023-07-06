using Application.Contract.Persistance.EntitiesRepository.Project;
using Domain.Entities.Project;

namespace BackEnd_Persistence.Repositories.Project
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        private readonly RealEstateDbContext _dbContext;
        public CountryRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
