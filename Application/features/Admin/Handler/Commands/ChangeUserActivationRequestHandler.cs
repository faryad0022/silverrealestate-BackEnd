using Application.Const.Response;
using Application.Contract.Identity;
using Application.features.Admin.Request.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Admin.Handler.Commands
{
    public class ChangeUserActivationRequestHandler : IRequestHandler<ChangeUserActivationRequest, ResponseResultDTO>
    {
        private readonly IUserService _userService;

        public ChangeUserActivationRequestHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ResponseResultDTO> Handle(ChangeUserActivationRequest request, CancellationToken cancellationToken)
        {
            var user = await _userService.ChangeUserActivation(request.userId);
            if (user is null)
            {
                return ResponseResultDTO.SetResult(user, StatusMessage.NotFound, null);
            }
            return ResponseResultDTO.SetResult(user, StatusMessage.Success, null);
        }
    }
}
