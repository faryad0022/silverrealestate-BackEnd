using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.BannerFeatures.Request.Commands
{
    public class CreateBannerRequest : IRequest<ResponseResultDTO>
    {
        public CreateBannerDTO createBannerDTO { get; set; }
    }
}
