using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.BannerFeatures.Request.Commands
{
    public class CreateBannerRequest : IRequest<ReturnData<BannerDTO>>
    {
        public CreateBannerDTO createBannerDTO { get; set; }
    }
}
