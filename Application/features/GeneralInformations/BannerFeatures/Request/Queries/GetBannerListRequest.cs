using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.BannerFeatures.Request.Queries
{
    public class GetBannerListRequest : IRequest<ReturnData<BannerDTO>>
    {
        public bool justShowSelected { get; set; } = false;

    }
}
