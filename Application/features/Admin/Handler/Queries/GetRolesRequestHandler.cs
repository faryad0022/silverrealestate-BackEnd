using Application.Const.Response;
using Application.Contract.Identity;
using Application.features.Admin.Request.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Admin.Handler.Queries
{
    public class GetRolesRequestHandler : IRequestHandler<GetRolesRequest, ResponseResultDTO>
    {
        private readonly IUserService _userService;

        public GetRolesRequestHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ResponseResultDTO> Handle(GetRolesRequest request, CancellationToken cancellationToken)
        {
            var roles = await _userService.GetRolesAsync();
            return ResponseResultDTO.SetResult(roles, StatusMessage.Success, null);
        }
    }
}
