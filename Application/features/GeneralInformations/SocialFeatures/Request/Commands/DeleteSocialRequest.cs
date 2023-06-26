using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using MediatR;

namespace Application.features.GeneralInformations.SocialFeatures.Request.Commands
{
    public class DeleteSocialRequest : IRequest<ResponseResult>
    {
        public long Id { get; set; }
    }
}
