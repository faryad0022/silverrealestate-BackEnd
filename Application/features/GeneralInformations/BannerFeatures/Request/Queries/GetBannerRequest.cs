using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.BannerFeatures.Request.Queries
{
    public class GetBannerRequest : IRequest<ReturnData<BannerDTO>>
    {
        public long Id { get; set; }
    }
}
