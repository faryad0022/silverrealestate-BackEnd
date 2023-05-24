using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Persistence.Repositories.GeneralInformations
{
    public class SpectacularLocationImageRepository : GenericRepository<SpectacularLocationImages>, ISpectacularLocationImageRepository
    {
        private readonly RealEstateDbContext _dbContext;
        public SpectacularLocationImageRepository(RealEstateDbContext dbConText) : base(dbConText)
        {
            _dbContext = dbConText;
        }

        public async Task<List<SpectacularLocationImages>> GetSpectacularLocationImagesListWithDetails() =>
             await _dbContext.SpectacularLocationImages.Include(s => s.Spectacularlocation).ToListAsync();


        public async Task<SpectacularLocationImages> GetSpectacularLocationImagesWithDetails(long Id)
        {
            var spectacularLocationImage = await _dbContext.SpectacularLocationImages
                .Include(s => s.Spectacularlocation)
                .Where(s => s.Id == Id)
                .FirstOrDefaultAsync();
            return spectacularLocationImage;
        }
    }
}
