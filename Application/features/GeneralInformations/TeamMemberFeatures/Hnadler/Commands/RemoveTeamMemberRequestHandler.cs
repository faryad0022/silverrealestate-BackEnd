using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Hnadler.Commands
{
    public class RemoveTeamMemberRequestHandler : IRequestHandler<RemoveTeamMemberRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public RemoveTeamMemberRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(RemoveTeamMemberRequest request, CancellationToken cancellationToken)
        {
            var teamMember = await _unitofWork.TeamMemberRepository.GetEntityAsync(request.Id);
            var teamMemberDTO = _mapper.Map<TeamMemberDTO>(teamMember);
            if (teamMember is null)
            {
                return ResponseResultDTO.SetResult(
                    null,
                    StatusMessage.NotFound,
                    null
                    );
            }
            _unitofWork.TeamMemberRepository.DeleteEntity(teamMember);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(
                teamMemberDTO,
                StatusMessage.Success,
                null
                );
        }
    }
}
