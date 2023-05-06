using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using Domain.Entities.GeneralSiteInformation;

namespace BackEnd_Persistence.Repositories.GeneralInformations
{
    public class CommonQuestionRepository : GenericRepository<CommonQuestion>, ICommonQuestionRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public CommonQuestionRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
