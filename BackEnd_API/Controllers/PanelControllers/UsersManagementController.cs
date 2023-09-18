using Application.Const.Response;
using Application.Contract.Identity;
using Application.features.Admin.Request.Commands;
using Application.features.Admin.Request.Queries;
using Application.Models.Identity;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{
    public class UsersManagementController : AdminBaseController
    {
        private readonly IMediator _mediator;
        private readonly IUserService _userService;

        public UsersManagementController(IMediator mediator, IUserService userService)
        {
            _mediator = mediator;
            _userService = userService;
        }
        [HttpGet(ApiRouteV1.GetUsersList, Name = "GetUsersList")]
        public async Task<ActionResult<ResponseResultDTO>> GetUsersList()
             => await _mediator.Send(new GetUserListRequest());

        [HttpGet(ApiRouteV1.GetRolesList, Name = "GetRolesList")]
        public async Task<ActionResult<ResponseResultDTO>> GetRolesList()
            => await _mediator.Send(new GetRolesRequest());

        [HttpGet(ApiRouteV1.GetUsersInRole, Name = "GetUsersInRole")]
        public async Task<ActionResult<ResponseResultDTO>> GetUsersInRole([FromQuery] string roleName)
             => await _mediator.Send(new GetUsersInRoleRequest() { roleName = roleName });

        [HttpPost(ApiRouteV1.UpdateUserRole, Name = "UpdateUserRole")]
        public async Task<ActionResult<ResponseResultDTO>> UpdateUserRole([FromBody] UserRoleDTO userRoleDTO)
            => await _mediator.Send(new UpdateUserRoleRequest() { userId = userRoleDTO.UserId, roleName = userRoleDTO.RoleName });

        [HttpPost(ApiRouteV1.AddNewUser, Name = "AddNewUser")]
        public async Task<ActionResult<ResponseResultDTO>> AddNewUser([FromBody] RegisterRequestDTO request)
            => await _mediator.Send(new AddNewUserRequest() { request = request });

        [HttpPut(ApiRouteV1.ChangeUserActivation, Name = "ChangeUserActivation")]
        public async Task<ActionResult<ResponseResultDTO>> ChangeUserActivation([FromBody] RegisteredUserDTO user)
            => await _mediator.Send(new ChangeUserActivationRequest() { userId = user.Id });

        [HttpPut(ApiRouteV1.ChangePassword, Name = "ChangePassword")]
        public async Task<ActionResult<ResponseResultDTO>> ChangePassword([FromBody] string userId, string password)
            => await _mediator.Send(new ChangePasswordRequest() { userId = userId, newPassword = password });

        [HttpGet(ApiRouteV1.GetUserRoles, Name = "GetUserRoles")]
        public async Task<ActionResult<ResponseResultDTO>> GetUserRoles([FromQuery] string UserId)
            => await _mediator.Send(new GetUserRolesRequest() { userId = UserId });
    }

}

