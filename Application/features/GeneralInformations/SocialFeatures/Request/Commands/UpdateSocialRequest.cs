using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using MediatR;

namespace Application.features.GeneralInformations.SocialFeatures.Request.Commands
{
    public class UpdateSocialRequest : IRequest<ResponseResultDTO>
    {
        public UpdateSocialDTO UpdateSocialDTO { get; set; }
    }
}
