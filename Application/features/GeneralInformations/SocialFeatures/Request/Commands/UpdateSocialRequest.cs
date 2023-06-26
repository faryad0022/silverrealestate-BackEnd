using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using MediatR;

namespace Application.features.GeneralInformations.SocialFeatures.Request.Commands
{
    public class UpdateSocialRequest : IRequest<ResponseResult>
    {
        public UpdateSocialDTO UpdateSocialDTO { get; set; }
    }
}
