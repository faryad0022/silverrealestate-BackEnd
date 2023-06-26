﻿using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands
{
    public class CreateTeamMemberRequest : IRequest<ResponseResult>
    {
        public CreateTeamMmeberDTO createTeamMmeberDTO { get; set; }
    }
}
