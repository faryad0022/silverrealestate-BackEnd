using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.SocialFeatures.Request.Commands
{
    public class UpdateSocialRequest : IRequest<ReturnData<UpdateSocialDTO>>
    {
        public UpdateSocialDTO UpdateSocialDTO { get; set; }
    }
}
