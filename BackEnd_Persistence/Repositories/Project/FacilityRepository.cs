using Application.Contract.Persistance.EntitiesRepository.Project;
using Domain.Entities.Project;

namespace BackEnd_Persistence.Repositories.Project
{
    public class FacilityRepository : GenericRepository<Facility>, IFacilityRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public FacilityRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
