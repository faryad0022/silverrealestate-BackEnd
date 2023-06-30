using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.SocialFeatures.Request.Queries
{
    public class GetSocialListRequest : IRequest<ResponseResultDTO>
    {
        public bool justShowSelected { get; set; } = false;
    }
}
