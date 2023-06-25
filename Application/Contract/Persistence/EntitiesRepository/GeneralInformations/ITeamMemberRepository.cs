using Application.Contract.Persistence.CommonGenericRepository;
using Application.Models.FilterModels;
using Domain.Entities.GeneralSiteInformation;
using System.Threading.Tasks;

namespace Application.Contract.Persistence.EntitiesRepository.GeneralInformations
{
    public interface ITeamMemberRepository : IGenericRepository<TeamMember>
    {
        Task<FilterTeamMember> FilterTeamMembers(FilterTeamMember filter);
    }
}
