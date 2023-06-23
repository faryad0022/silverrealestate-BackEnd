using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.SocialFeatures.Request.Commands
{
    public class DeleteSocialRequest : IRequest<ReturnData<SocialDTO>>
    {
        public long Id { get; set; }
    }
}
