using Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberSocialFeatures.Request.Commands
{
    public class UpdateTeamMemberSocialRequest : IRequest<ReturnData<TeamMemberSocialDTO>>
    {
        public UpdateTeamMemberSocialDTO updateTeamMemberSocialDTO { get; set; }
    }
}
