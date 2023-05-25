using Application.Contract.Persistence.CommonGenericRepository;
using Domain.Entities.GeneralSiteInformation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contract.Persistence.EntitiesRepository.GeneralInformations
{
    public interface ITeamMemberSocialRepository : IGenericRepository<TeamMemberSocial>
    {
        Task<List<TeamMemberSocial>> GetTeamMemberSocialListWithDetails();
        Task<TeamMemberSocial> GetTeamMemberSocialWithDetails(long Id);
    }
}
