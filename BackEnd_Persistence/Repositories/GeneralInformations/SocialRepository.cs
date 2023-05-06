using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using Domain.Entities.GeneralSiteInformation;

namespace BackEnd_Persistence.Repositories.GeneralInformations
{

    public class SocialRepository : GenericRepository<Social>, ISocialRepository
    {
        private readonly RealEstateDbContext _dbContext;
        public SocialRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }


}
