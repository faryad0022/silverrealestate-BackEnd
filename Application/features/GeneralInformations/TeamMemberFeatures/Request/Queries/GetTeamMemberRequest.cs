﻿using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Queries
{
    public class GetTeamMemberRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
