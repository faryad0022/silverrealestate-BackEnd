using Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberSocialFeatures.Request.Queries
{
    public class GetTeamMemberSocialListWithDetails : IRequest<ReturnData<TeamMemberSocialDTO>>
    {
        public bool justSelected { get; set; } = false;
    }
}
