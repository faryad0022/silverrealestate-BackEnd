using Application.Const.Response;
using Application.Contract.Identity;
using Application.features.GeneralInformations.PropfileFeatures.Request.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.PropfileFeatures.Handler.Queries
{
    public class GetCurrentUserProfileRequestHandler : IRequestHandler<GetCurrentUserProfileRequest, ResponseResultDTO>
    {
        private readonly IUserService _userService;

        public GetCurrentUserProfileRequestHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ResponseResultDTO> Handle(GetCurrentUserProfileRequest request, CancellationToken cancellationToken)
        {
            var currentUser = await _userService.GetCurrentUserByIdAsync(request.userId);
            return ResponseResultDTO.SetResult(currentUser, StatusMessage.Success, null);

        }
    }
}
