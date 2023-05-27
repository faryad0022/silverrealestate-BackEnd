using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials;
using Application.features.GeneralInformations.TeamMemberSocialFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.TeamMemberSocialFeatures.Handler.Queries
{
    public class GetTeamMemberSocialListWithDetailsHandler : IRequestHandler<GetTeamMemberSocialListWithDetails, ReturnData<TeamMemberSocialDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetTeamMemberSocialListWithDetailsHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ReturnData<TeamMemberSocialDTO>> Handle(GetTeamMemberSocialListWithDetails request, CancellationToken cancellationToken)
        {
            var teamMemberSocialList = await _unitofWork.TeamMemberSocialRepository.GetTeamMemberSocialListWithDetails();
            if (teamMemberSocialList is null || teamMemberSocialList.Count < 1)
                return FillRetuenData<TeamMemberSocialDTO>.FillByListEntity(null, ResponseStatus.NoContent, null);
            if (request.justSelected)
            {
                var selectedTeamMember = teamMemberSocialList.Where(s => s.IsSelected).ToList();
                return FillRetuenData<TeamMemberSocialDTO>.FillByListEntity(
                    _mapper.Map<List<TeamMemberSocialDTO>>(selectedTeamMember),
                    ResponseStatus.Success,
                    null
                    );
            }
            return FillRetuenData<TeamMemberSocialDTO>.FillByListEntity(
                    _mapper.Map<List<TeamMemberSocialDTO>>(teamMemberSocialList),
                    ResponseStatus.Success,
                    null
                    );
        }
    }
}
