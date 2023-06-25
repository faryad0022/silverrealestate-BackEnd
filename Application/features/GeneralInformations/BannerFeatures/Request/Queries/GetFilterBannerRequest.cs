using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.BannerFeatures.Request.Queries
{
    public class GetFilterBannerRequest : IRequest<ReturnData<FilterBannerDTO>>
    {
        public FilterBannerDTO filter { get; set; }
    }
}
