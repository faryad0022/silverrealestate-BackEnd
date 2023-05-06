using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using Domain.Entities.GeneralSiteInformation;

namespace BackEnd_Persistence.Repositories.GeneralInformations
{
    public class ConstructorInfromationRepository : GenericRepository<ConstructorInformation>, IConstructorInfromationRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public ConstructorInfromationRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
