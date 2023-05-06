using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.SocialFeatures.Request.Queries
{

    public class GetSocialRequest : IRequest<ReturnData<SocialDTO>>
    {
        public long Id { get; set; }
    }
}
