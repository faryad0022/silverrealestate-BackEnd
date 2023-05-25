using Application.Contract.Persistence.CommonGenericRepository;
using Domain.Entities.GeneralSiteInformation;
using System.Threading.Tasks;

namespace Application.Contract.Persistence.EntitiesRepository.GeneralInformations
{
    public interface IAboutUsRepository : IGenericRepository<AboutUs>
    {
        Task<int> GetAboutUsCountAsync();
    }
}
