using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Persistence.Repositories.GeneralInformations
{
    public class TeamMemberSocialRepository : GenericRepository<TeamMemberSocial>, ITeamMemberSocialRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public TeamMemberSocialRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<TeamMemberSocial>> GetTeamMemberSocialListWithDetails()
            => await _dbContext.TeamMemberSocials.Include(x => x.TeamMember).ToListAsync();


        public async Task<TeamMemberSocial> GetTeamMemberSocialWithDetails(long Id)
            => await _dbContext.TeamMemberSocials.Include(t => t.TeamMember).FirstOrDefaultAsync(t => t.Id == Id);

    }
}
