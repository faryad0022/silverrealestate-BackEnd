using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using Domain.Entities.GeneralSiteInformation;

namespace BackEnd_Persistence.Repositories.GeneralInformations
{
    public class SpectacularlocationRepository : GenericRepository<Spectacularlocation>, ISpectacularlocationRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public SpectacularlocationRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
