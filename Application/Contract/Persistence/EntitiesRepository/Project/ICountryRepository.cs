using Application.Contract.Persistence.CommonGenericRepository;
using Domain.Entities.Project;
using System.Threading.Tasks;

namespace Application.Contract.Persistance.EntitiesRepository.Project
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        Task<bool> CheckDuplicate(string countryName);
    }
}
