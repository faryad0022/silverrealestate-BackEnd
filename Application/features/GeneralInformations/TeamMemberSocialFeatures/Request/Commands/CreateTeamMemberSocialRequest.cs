using Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberSocialFeatures.Request.Commands
{
    public class CreateTeamMemberSocialRequest : IRequest<ReturnData<TeamMemberSocialDTO>>
    {
        public CreateTeamMemberSocialDTO createTeamMemberSocialDTO { get; set; }
    }
}
