using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using MediatR;

namespace Application.features.GeneralInformations.SocialFeatures.Request.Commands
{

    public class CreateSocialRequest : IRequest<ResponseResultDTO>
    {
        public CreateSocialDTO createSocialDTO { get; set; }
    }
}
