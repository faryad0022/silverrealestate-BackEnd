using Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials;
using Application.features.GeneralInformations.TeamMemberSocialFeatures.Request.Commands;
using Application.features.GeneralInformations.TeamMemberSocialFeatures.Request.Queries;
using Application.Reaspose;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AdminControllers
{

    public class TeamMemberSocialController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public TeamMemberSocialController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.TeamMemberSocial_GetAll_WithDetails,Name = "GetAllTeamMemberSocialWithDetails")]
        public async Task<ActionResult<ReturnData<TeamMemberSocialDTO>>> GetAllTeamMemberSocialWithDetails()
            => await _mediator.Send(new GetTeamMemberSocialListWithDetails());

        [HttpGet(ApiRouteV1.TeamMemberSocial_Get_WithDetails, Name = "GetTeamMemberSocialWithDetails")]
        public async Task<ActionResult<ReturnData<TeamMemberSocialDTO>>> GetTeamMemberSocialWithDetails([FromQuery] long Id)
            => await _mediator.Send(new GetTeamMemberSocialWithDetailsRequest() { Id = Id });

        [HttpPost(ApiRouteV1.TeamMemberSocial_Add, Name = "AddTeamMemberSocial")]
        public async Task<ActionResult<ReturnData<TeamMemberSocialDTO>>> AddTeamMemberSocial([FromBody] CreateTeamMemberSocialDTO teammembersocialDTO)
            => await _mediator.Send(new CreateTeamMemberSocialRequest() { createTeamMemberSocialDTO = teammembersocialDTO });

        [HttpPut(ApiRouteV1.TeamMemberSocial_Update, Name = "UpdateTeamMemberSocial")]
        public async Task<ActionResult<ReturnData<TeamMemberSocialDTO>>> UpdateTeamMemberSocial([FromQuery] UpdateTeamMemberSocialDTO teammembersocialDTO)
            => await _mediator.Send(new UpdateTeamMemberSocialRequest() { updateTeamMemberSocialDTO = teammembersocialDTO });

        [HttpPut(ApiRouteV1.TeamMemberSocial_ChangeStatus, Name = "ChangeTeamMemberSocialStatus")]
        public async Task<ActionResult<ReturnData<TeamMemberSocialDTO>>> ChangeTeamMemberSocialStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeTeamMemberSocialSelectedStatusRequest() { Id = Id });
    }
}
