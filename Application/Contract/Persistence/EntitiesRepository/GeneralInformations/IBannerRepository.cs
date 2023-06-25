using Application.Contract.Persistence.CommonGenericRepository;
using Application.DTOs.Filters;
using Application.Filters;
using Domain.Entities.GeneralSiteInformation;
using System.Threading.Tasks;

namespace Application.Contract.Persistence.EntitiesRepository.GeneralInformations
{
    public interface IBannerRepository : IGenericRepository<Banner>
    {
        Task<FilterBanner> FilterBanners(FilterBanner filter);
    }
}
