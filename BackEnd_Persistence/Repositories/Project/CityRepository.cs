using Application.Contract.Persistance.EntitiesRepository.Project;
using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Persistence.Repositories.Project
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public CityRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<City>> GetCityListOfCountryWithDetailsAsync(long countryId)
        {
            var cityList = _dbContext.Cities.Include(c => c.Country).Where(c => c.CountryId == countryId).ToListAsync();
            return cityList;
        }

        public async Task<List<City>> GetCityListWithDetailsAsync()
        {
            var cityList = await _dbContext.Cities.Include(c => c.Country).ToListAsync();
            return cityList;
        }

        public async Task<City> GetCityWithDetailsAsync(long id)
        {
            var city = await _dbContext.Cities.Include(c => c.Country).SingleOrDefaultAsync(c => c.Id == id);
            return city;
        }
    }
}
