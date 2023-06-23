using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.BannerFeatures.Request.Commands
{
    public class DeleteBannerRequest : IRequest<ReturnData<BannerDTO>>
    {
        public long Id { get; set; }
    }
}
