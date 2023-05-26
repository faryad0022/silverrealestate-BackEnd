using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials;
using Application.features.GeneralInformations.TeamMemberSocialFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.TeamMemberSocialFeatures.Handler.Queries
{
    public class GetTeamMemberSocialWithDetailsRequestHandler : IRequestHandler<GetTeamMemberSocialWithDetailsRequest, ReturnData<TeamMemberSocialDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetTeamMemberSocialWithDetailsRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ReturnData<TeamMemberSocialDTO>> Handle(GetTeamMemberSocialWithDetailsRequest request, CancellationToken cancellationToken)
        {
            var teamMemberSocial = await _unitofWork.TeamMemberSocialRepository.GetTeamMemberSocialWithDetails(request.Id);
            if (teamMemberSocial is null)
                return FillRetuenData<TeamMemberSocialDTO>.FillByEntity(null, ResponseStatus.NotFound, null);

            return FillRetuenData<TeamMemberSocialDTO>.FillByEntity(
                    _mapper.Map<TeamMemberSocialDTO>(teamMemberSocial),
                    ResponseStatus.Success,
                    null
                    );
        }
    }
}
