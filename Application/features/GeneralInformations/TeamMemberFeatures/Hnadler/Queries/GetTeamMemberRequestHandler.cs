﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.features.GeneralInformations.TeamMemberFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Hnadler.Queries
{
    public class GetTeamMemberRequestHandler : IRequestHandler<GetTeamMemberRequest, ReturnData<TeamMemberDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetTeamMemberRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<TeamMemberDTO>> Handle(GetTeamMemberRequest request, CancellationToken cancellationToken)
        {
            var teamMember = await _unitofWork.TeamMemberRepository.GetEntityAsync(request.Id);
            if (teamMember is null)
                return FillRetuenData<TeamMemberDTO>.FillByEntity(null, ResponseStatus.NotFound, null);
            return FillRetuenData<TeamMemberDTO>.FillByEntity(
                _mapper.Map<TeamMemberDTO>(teamMember),
                ResponseStatus.Success,
                null
                );
        }
    }
}
