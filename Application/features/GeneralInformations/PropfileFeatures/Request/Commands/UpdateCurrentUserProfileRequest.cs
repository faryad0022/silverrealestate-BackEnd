using Application.Const.Response;
using Application.Models.Identity;
using MediatR;

namespace Application.features.GeneralInformations.PropfileFeatures.Request.Commands
{
    public class UpdateCurrentUserProfileRequest : IRequest<ResponseResultDTO>
    {
        public CurrentUser currentUser { get; set; }
    }
}
