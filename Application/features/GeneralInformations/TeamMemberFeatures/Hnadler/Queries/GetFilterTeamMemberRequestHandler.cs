using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.features.GeneralInformations.TeamMemberFeatures.Request.Queries;
using Application.Models.FilterModels;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Hnadler.Queries
{
    public class GetFilterTeamMemberRequestHandler : IRequestHandler<GetFilterTeamMemberRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetFilterTeamMemberRequestHandler(IMapper mapper,IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(GetFilterTeamMemberRequest request, CancellationToken cancellationToken)
        {
            var filter = _mapper.Map<FilterTeamMember>(request.filter);
            var teamMember = await _unitofWork.TeamMemberRepository.FilterTeamMembers(filter);
            var teamMemberDTO = _mapper.Map<FilterTeamMemberDTO>(teamMember);
            if (teamMember.TeamMembers is null || teamMember.TeamMembers.Count < 1)
                return ResponseResult.SetResult(teamMemberDTO,StatusMessage.NoContent,null);
            return ResponseResult.SetResult(teamMemberDTO, StatusMessage.Success, null);

        }
    }
}
