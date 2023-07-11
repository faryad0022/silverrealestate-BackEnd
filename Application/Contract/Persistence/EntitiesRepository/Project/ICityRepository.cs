using Application.Contract.Persistence.CommonGenericRepository;
using Domain.Entities.Project;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contract.Persistance.EntitiesRepository.Project
{
    public interface ICityRepository : IGenericRepository<City>
    {
        Task<City> GetCityWithDetailsAsync(long id);
        Task<List<City>> GetCityListWithDetailsAsync();
        Task<List<City>> GetCityListOfCountryWithDetailsAsync(long countryId);
        Task<bool> CheckDuplicateCity(string cityName);
    }
}
