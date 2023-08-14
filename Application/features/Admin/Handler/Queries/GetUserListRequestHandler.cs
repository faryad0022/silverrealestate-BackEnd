using Application.Const.Response;
using Application.Contract.Identity;
using Application.features.Admin.Request.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Admin.Handler.Queries
{
    public class GetUserListRequestHandler : IRequestHandler<GetUserListRequest, ResponseResultDTO>
    {
        private readonly IUserService _userService;

        public GetUserListRequestHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ResponseResultDTO> Handle(GetUserListRequest request, CancellationToken cancellationToken)
        {
            var userList = await _userService.GetRegisteredUserListAsync();
            return ResponseResultDTO.SetResult(userList, StatusMessage.Success, null);
        }
    }
}
