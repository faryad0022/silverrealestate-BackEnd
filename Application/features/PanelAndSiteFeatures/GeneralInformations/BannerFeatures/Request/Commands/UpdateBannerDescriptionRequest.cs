using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.BannerFeatures.Request.Commands
{
    public class UpdateBannerDescriptionRequest : IRequest<ResponseResultDTO>
    {
        public UpdateBannerDescriptionDTO updateBannerDescriptionDTO { get; set; }
    }
}
