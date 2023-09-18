using Application.Contract.Persistance.EntitiesRepository.Project;
using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BackEnd_Persistence.Repositories.Project
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        private readonly RealEstateDbContext _dbContext;
        public CountryRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CheckDuplicate(string countryName)
        {
            var country = await _dbContext.Countries.FirstOrDefaultAsync(c => c.CountryName == countryName);
            if (country is null)
                return true;
            return false;
        }
    }
}
