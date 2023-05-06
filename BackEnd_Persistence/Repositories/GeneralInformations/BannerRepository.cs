using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using Domain.Entities.GeneralSiteInformation;

namespace BackEnd_Persistence.Repositories.GeneralInformations
{
    public class BannerRepository : GenericRepository<Banner>, IBannerRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public BannerRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
