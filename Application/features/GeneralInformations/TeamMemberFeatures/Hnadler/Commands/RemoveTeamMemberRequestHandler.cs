using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Hnadler.Commands
{
    public class RemoveTeamMemberRequestHandler : IRequestHandler<RemoveTeamMemberRequest, ReturnData<TeamMemberDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public RemoveTeamMemberRequestHandler(IMapper mapper,IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<TeamMemberDTO>> Handle(RemoveTeamMemberRequest request, CancellationToken cancellationToken)
        {
            var teamMember = await _unitofWork.TeamMemberRepository.GetEntityAsync(request.Id);
            var teamMemberDTO = _mapper.Map<TeamMemberDTO>(teamMember);
            if (teamMember is null)
            {
                return SetReturnData<TeamMemberDTO>.SetTEntity(
                    null,
                    ResponseStatus.NotFound,
                    null
                    );
            }
            _unitofWork.TeamMemberRepository.DeleteEntityAsync(teamMember);
            await _unitofWork.SaveChangesAsync();
            return SetReturnData<TeamMemberDTO>.SetTEntity(
                teamMemberDTO,
                ResponseStatus.Success,
                null
                );
        }
    }
}
