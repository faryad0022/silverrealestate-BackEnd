using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands;
using Application.features.GeneralInformations.TeamMemberFeatures.Request.Queries;
using Application.Reaspose;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AdminControllers
{

    public class TeamMemberController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public TeamMemberController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get-all-team-members")]
        public async Task<ActionResult<ReturnData<TeamMemberDTO>>> GetAllTeamMembers()
            => await _mediator.Send(new GetTeamMemberListRequest());

        [HttpGet("get-team-member")]
        public async Task<ActionResult<ReturnData<TeamMemberDTO>>> GetTeamMember([FromQuery] long Id)
            => await _mediator.Send(new GetTeamMemberRequest() { Id = Id });

        [HttpPost("add-team-member")]
        public async Task<ActionResult<ReturnData<TeamMemberDTO>>> AddTeamMember([FromBody] CreateTeamMmeberDTO teammemberDTO)
            => await _mediator.Send(new CreateTeamMemberRequest() { createTeamMmeberDTO = teammemberDTO });

        [HttpPut("change-team-member-selected-status")]
        public async Task<ActionResult<ReturnData<TeamMemberDTO>>> ChangeTeamMemberStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeTeamMemberSelectedStatusRequest() { Id = Id });

        [HttpPut("update-team-member-selected-status")]
        public async Task<ActionResult<ReturnData<TeamMemberDTO>>> UpdateTeamMemberStatus([FromQuery] UpdateTeamMemberDTO updateTeamMemberDTO)
            => await _mediator.Send(new UpdateTeamMemberRequest() { updateTeamMemberDTO = updateTeamMemberDTO });
    }
}
