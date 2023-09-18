using Application.Const.Response;
using Application.Contract.Identity;
using Application.features.Admin.Request.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Admin.Handler.Commands
{
    public class UpdateUserRoleRequestHandler : IRequestHandler<UpdateUserRoleRequest, ResponseResultDTO>
    {
        private readonly IUserService _userService;

        public UpdateUserRoleRequestHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ResponseResultDTO> Handle(UpdateUserRoleRequest request, CancellationToken cancellationToken)
        {
            var user = await _userService.UpdateUserRoleAsync(request.userId, request.roleName);
            return ResponseResultDTO.SetResult(user, StatusMessage.Success, null);
        }
    }
}
