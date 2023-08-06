using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.PropfileFeatures.Request.Queries
{
    public class GetCurrentUserProfileRequest : IRequest<ResponseResultDTO>
    {
        public string userId { get; set; }
    }
}
