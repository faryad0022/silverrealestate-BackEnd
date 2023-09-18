using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.features.PanelAndSiteFeatures.GeneralInformations.TeamMemberFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.TeamMemberFeatures.Hnadler.Queries
{
    public class GetTeamMemberRequestHandler : IRequestHandler<GetTeamMemberRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetTeamMemberRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetTeamMemberRequest request, CancellationToken cancellationToken)
        {
            var teamMember = await _unitofWork.TeamMemberRepository.GetEntityAsync(request.Id);
            if (teamMember is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            return ResponseResultDTO.SetResult(
                _mapper.Map<TeamMemberDTO>(teamMember),
                StatusMessage.Success,
                null
                );
        }
    }
}
