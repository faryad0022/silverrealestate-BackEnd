using Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberSocialFeatures.Request.Commands
{
    public class ChangeTeamMemberSocialSelectedStatusRequest : IRequest<ReturnData<TeamMemberSocialDTO>>
    {
        public long Id { get; set; }
    }
}
