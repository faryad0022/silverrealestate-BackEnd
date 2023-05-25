using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using Domain.Entities.GeneralSiteInformation;

namespace BackEnd_Persistence.Repositories.GeneralInformations
{
    public class TeamMemberRepository : GenericRepository<TeamMember>, ITeamMemberRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public TeamMemberRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
