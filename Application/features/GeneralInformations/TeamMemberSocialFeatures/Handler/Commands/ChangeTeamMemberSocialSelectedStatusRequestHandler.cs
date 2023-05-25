using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials;
using Application.features.GeneralInformations.TeamMemberSocialFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.TeamMemberSocialFeatures.Handler.Commands
{
    public class ChangeTeamMemberSocialSelectedStatusRequestHandler : IRequestHandler<ChangeTeamMemberSocialSelectedStatusRequest, ReturnData<TeamMemberSocialDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public ChangeTeamMemberSocialSelectedStatusRequestHandler(
            IMapper mapper,
            IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ReturnData<TeamMemberSocialDTO>> Handle(ChangeTeamMemberSocialSelectedStatusRequest request, CancellationToken cancellationToken)
        {
            var teamMemberSocial = await _unitofWork.TeamMemberSocialRepository.GetEntityAsync(request.Id);
            if (teamMemberSocial is null)
                return FillRetuenData<TeamMemberSocialDTO>.FillByEntity(null, ResponseStatus.NotFound, null);
            _unitofWork.TeamMemberSocialRepository.ChangeSelectedStatusAsync(teamMemberSocial);
            await _unitofWork.SaveChangesAsync();
            return FillRetuenData<TeamMemberSocialDTO>.FillByEntity(
                _mapper.Map<TeamMemberSocialDTO>(teamMemberSocial),
                ResponseStatus.Success,
                null
                );
        }
    }
}
