using Application.Const.Response;
using Application.Contract.Identity;
using Application.features.GeneralInformations.PropfileFeatures.Request.Commands;
using Application.features.GeneralInformations.PropfileFeatures.Request.Queries;
using Application.Models.Identity;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{
    [Authorize]
    public class ProfileController : AdminBaseController
    {
        private readonly IMediator _mediator;
        private readonly IAuthService _authService;

        public ProfileController(IMediator mediator, IAuthService authService)
        {
            _mediator = mediator;
            _authService = authService;
        }
        [HttpGet(ApiRouteV1.GetCurrentUserProfile, Name = "GetCurrentUserProfile")]
        public async Task<ActionResult<ResponseResultDTO>> GetCurrentUserProfile()
            => await _mediator.Send(new GetCurrentUserProfileRequest() { userId = _authService.GetUserId() });
        [HttpPost(ApiRouteV1.UpdateCurrentUserProfile, Name = "UpdateCurrentUserProfile")]
        public async Task<ActionResult<ResponseResultDTO>> UpdateCurrentUserProfile([FromBody] CurrentUserDTO currentUser)
            => await _mediator.Send(new UpdateCurrentUserProfileRequest() { currentUser = currentUser });
    }
}
