using Application.Const.Response;
using Application.features.Auth.Request.Command;
using Application.Models.Identity;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AuthControllers
{
    [AllowAnonymous]
    public class AccountController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost(ApiRouteV1.Login, Name = "Login")]
        public async Task<ActionResult<ResponseResultDTO>> Login([FromBody] AuthRequest authRequest)
            => await _mediator.Send(new SignInRequest() { authRequest = authRequest });
        [HttpPost(ApiRouteV1.Register, Name = "Register")]
        public async Task<ActionResult<ResponseResultDTO>> Register([FromBody] RegisterRequest registerRequest)
            => await _mediator.Send(new RegisterationRequest() { registerRequest = registerRequest });
        [HttpPost(ApiRouteV1.Authenticated, Name = "CheckUserAuth")]
        public async Task<ActionResult<ResponseResultDTO>> CheckUserAuth()
            => await _mediator.Send(new CheckUserAuthRequest());
        [HttpGet(ApiRouteV1.LogOut, Name = "LogOut")]
        public async Task<ActionResult<ResponseResultDTO>> LogOut()
        {
            if (User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync();
                return ResponseResultDTO.SetResult(null, StatusMessage.Success, null);
            }
            return ResponseResultDTO.SetResult(null, StatusMessage.Error, null);
        }
    }
}
