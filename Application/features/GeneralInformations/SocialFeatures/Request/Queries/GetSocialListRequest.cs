using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using MediatR;

namespace Application.features.GeneralInformations.SocialFeatures.Request.Queries
{
    public class GetSocialListRequest : IRequest<ResponseResult>
    {
        public bool justShowSelected { get; set; } = false;
    }
}
