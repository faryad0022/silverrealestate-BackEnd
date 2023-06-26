using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Hnadler.Commands
{
    public class RemoveTeamMemberRequestHandler : IRequestHandler<RemoveTeamMemberRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public RemoveTeamMemberRequestHandler(IMapper mapper,IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(RemoveTeamMemberRequest request, CancellationToken cancellationToken)
        {
            var teamMember = await _unitofWork.TeamMemberRepository.GetEntityAsync(request.Id);
            var teamMemberDTO = _mapper.Map<TeamMemberDTO>(teamMember);
            if (teamMember is null)
            {
                return ResponseResult.SetResult(
                    null,
                    StatusMessage.NotFound,
                    null
                    );
            }
            _unitofWork.TeamMemberRepository.DeleteEntityAsync(teamMember);
            await _unitofWork.SaveChangesAsync();
            return ResponseResult.SetResult(
                teamMemberDTO,
                StatusMessage.Success,
                null
                );
        }
    }
}
