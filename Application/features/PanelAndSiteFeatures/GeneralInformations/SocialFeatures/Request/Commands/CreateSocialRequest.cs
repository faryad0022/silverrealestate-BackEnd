using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.SocialFeatures.Request.Commands
{

    public class CreateSocialRequest : IRequest<ResponseResultDTO>
    {
        public CreateSocialDTO createSocialDTO { get; set; }
    }
}
