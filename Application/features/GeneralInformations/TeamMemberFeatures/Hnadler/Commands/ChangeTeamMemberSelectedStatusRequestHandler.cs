using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Hnadler.Commands
{
    public class ChangeTeamMemberSelectedStatusRequestHandler : IRequestHandler<ChangeTeamMemberSelectedStatusRequest, ReturnData<TeamMemberDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public ChangeTeamMemberSelectedStatusRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ReturnData<TeamMemberDTO>> Handle(ChangeTeamMemberSelectedStatusRequest request, CancellationToken cancellationToken)
        {
            var teamMember = await _unitofWork.TeamMemberRepository.GetEntityAsync(request.Id);
            if (teamMember is null)
                return SetReturnData<TeamMemberDTO>.SetTEntity(null, ResponseStatus.NotFound, null);
            _unitofWork.TeamMemberRepository.ChangeSelectedStatusAsync(teamMember);
            await _unitofWork.SaveChangesAsync();
            return SetReturnData<TeamMemberDTO>.SetTEntity(
                _mapper.Map<TeamMemberDTO>(teamMember),
                ResponseStatus.Success,
                null
                );
        }
    }
}
