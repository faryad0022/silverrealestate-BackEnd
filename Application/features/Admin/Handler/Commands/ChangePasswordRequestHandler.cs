using Application.Const.Response;
using Application.Contract.Identity;
using Application.features.Admin.Request.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Admin.Handler.Commands
{
    public class ChangePasswordRequestHandler : IRequestHandler<ChangePasswordRequest, ResponseResultDTO>
    {
        private readonly IUserService _userService;

        public ChangePasswordRequestHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ResponseResultDTO> Handle(ChangePasswordRequest request, CancellationToken cancellationToken)
        {
            var user = await _userService.SetNewPassword(request.userId, request.newPassword);
            return ResponseResultDTO.SetResult(user, StatusMessage.Success, null);
        }
    }
}
