using Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberSocialFeatures.Request.Queries
{
    public class GetTeamMemberSocialWithDetailsRequest : IRequest<ReturnData<TeamMemberSocialDTO>>
    {
        public long Id { get; set; }
    }
}
