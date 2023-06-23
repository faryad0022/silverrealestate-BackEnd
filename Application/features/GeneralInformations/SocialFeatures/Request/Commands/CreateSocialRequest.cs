using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.SocialFeatures.Request.Commands
{

    public class CreateSocialRequest : IRequest<ReturnData<SocialDTO>>
    {
        public CreateSocialDTO createSocialDTO { get; set; }
    }
}
