using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using Domain.Entities.GeneralSiteInformation;

namespace BackEnd_Persistence.Repositories.GeneralInformations
{
    public class RealEstateServicesRepository : GenericRepository<RealEstateServices>, IRealEstateServicesRepository
    {
        private readonly RealEstateDbContext _dbContext;
        public RealEstateServicesRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
