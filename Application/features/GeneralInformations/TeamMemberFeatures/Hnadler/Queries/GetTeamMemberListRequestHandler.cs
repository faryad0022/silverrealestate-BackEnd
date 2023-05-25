using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.features.GeneralInformations.TeamMemberFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Hnadler.Queries
{
    public class GetTeamMemberListRequestHandler : IRequestHandler<GetTeamMemberListRequest, ReturnData<TeamMemberDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetTeamMemberListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<TeamMemberDTO>> Handle(GetTeamMemberListRequest request, CancellationToken cancellationToken)
        {
            var teamMemberList = await _unitofWork.TeamMemberRepository.GetAllAsync();
            if (teamMemberList is null || teamMemberList.Count < 1)
                return FillRetuenData<TeamMemberDTO>.FillByListEntity(null, ResponseStatus.NoContent, null);
            if (request.justSelected)
            {
                var selectedTeamMember = teamMemberList.Where(s => s.IsSelected).ToList();
                return FillRetuenData<TeamMemberDTO>.FillByListEntity(
                    _mapper.Map<List<TeamMemberDTO>>(selectedTeamMember),
                    ResponseStatus.Success,
                    null
                    );
            }
            return FillRetuenData<TeamMemberDTO>.FillByListEntity(
                    _mapper.Map<List<TeamMemberDTO>>(teamMemberList),
                    ResponseStatus.Success,
                    null
                    );
        }
    }
}
