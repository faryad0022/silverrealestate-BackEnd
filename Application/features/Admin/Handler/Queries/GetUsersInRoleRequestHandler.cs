using Application.Const.Response;
using Application.Contract.Identity;
using Application.features.Admin.Request.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Admin.Handler.Queries
{
    public class GetUsersInRoleRequestHandler : IRequestHandler<GetUsersInRoleRequest, ResponseResultDTO>
    {
        private readonly IUserService _userService;

        public GetUsersInRoleRequestHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ResponseResultDTO> Handle(GetUsersInRoleRequest request, CancellationToken cancellationToken)
        {
            var usersInRole = await _userService.GetRegisteredUserListInRoleAsync(request.roleName);
            return ResponseResultDTO.SetResult(usersInRole, StatusMessage.Success, null);
        }
    }
}
