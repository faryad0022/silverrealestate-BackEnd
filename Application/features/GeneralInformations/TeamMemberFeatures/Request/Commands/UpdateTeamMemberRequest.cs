﻿using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands
{
    public class UpdateTeamMemberRequest : IRequest<ResponseResultDTO>
    {
        public UpdateTeamMemberDTO updateTeamMemberDTO { get; set; }
    }
}
