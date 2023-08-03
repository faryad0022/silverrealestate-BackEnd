using Application.Contract.Identity;
using Application.Models.Identity;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{

    public class AccountController : AdminBaseController
    {
        private readonly IAuthService _authService;

        public AccountController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost(ApiRouteV1.Login,Name ="Login")]
        public async Task<ActionResult<AuthResponse>> Login(AuthRequest authRequest)
        {
            return Ok(await _authService.Login(authRequest));
        }
        [HttpPost(ApiRouteV1.Register, Name = "Register")]
        public async Task<ActionResult<RegisterResponse>> Register(RegisterRequest registerRequest)
        {
            return Ok(await _authService.Register(registerRequest));
        }
    }
}
