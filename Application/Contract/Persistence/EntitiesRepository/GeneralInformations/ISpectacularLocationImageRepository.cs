using Application.Contract.Persistence.CommonGenericRepository;
using Domain.Entities.GeneralSiteInformation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contract.Persistence.EntitiesRepository.GeneralInformations
{
    public interface ISpectacularLocationImageRepository : IGenericRepository<SpectacularLocationImages>
    {
        Task<SpectacularLocationImages> GetSpectacularLocationImagesWithDetails(long Id);
        Task<List<SpectacularLocationImages>> GetSpectacularLocationImagesListWithDetails();

    }
}
