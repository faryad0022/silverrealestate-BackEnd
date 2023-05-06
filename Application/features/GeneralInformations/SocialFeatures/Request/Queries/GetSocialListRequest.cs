using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.SocialFeatures.Request.Queries
{
    public class GetSocialListRequest : IRequest<ReturnData<SocialDTO>>
    {
        public bool justShowSelected { get; set; } = false;
    }
}
