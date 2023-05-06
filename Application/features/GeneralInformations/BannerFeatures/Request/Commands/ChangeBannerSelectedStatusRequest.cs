using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.BannerFeatures.Request.Commands
{
    public class ChangeBannerSelectedStatusRequest : IRequest<ReturnData<UpdateBannerDTO>>
    {
        public long Id { get; set; }
    }
}
