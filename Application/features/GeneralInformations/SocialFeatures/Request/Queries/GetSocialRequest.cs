using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.SocialFeatures.Request.Queries
{

    public class GetSocialRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
