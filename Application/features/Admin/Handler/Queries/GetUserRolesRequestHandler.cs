using Application.Const.Response;
using Application.Contract.Identity;
using Application.features.Admin.Request.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Admin.Handler.Queries
{
    public class GetUserRolesRequestHandler : IRequestHandler<GetUserRolesRequest, ResponseResultDTO>
    {
        private readonly IUserService _userService;

        public GetUserRolesRequestHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ResponseResultDTO> Handle(GetUserRolesRequest request, CancellationToken cancellationToken)
        {
            var userRoles = await _userService.GetUserRolesAsync(request.userId);
            return ResponseResultDTO.SetResult(userRoles,StatusMessage.Success,null);
        }
    }
}
