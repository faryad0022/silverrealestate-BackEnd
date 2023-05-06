using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Persistence.Repositories.GeneralInformations
{

    public class AboutUsRepository : GenericRepository<AboutUs>, IAboutUsRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public AboutUsRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> GetAboutUsCountAsync()
        {
            var aboutUsCount = await _dbContext.AboutUs.ToListAsync();
            return aboutUsCount.Count();
        }
    }


}
