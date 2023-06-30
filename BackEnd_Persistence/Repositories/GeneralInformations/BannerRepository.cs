using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using Application.DTOs.Paging;
using Application.Extensions;
using Application.Models.FilterModels;
using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Persistence.Repositories.GeneralInformations
{
    public class BannerRepository : GenericRepository<Banner>, IBannerRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public BannerRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<FilterBanner> FilterBanners(FilterBanner filter)
        {
            var bannersQuery = GetEntitiesQuery().AsQueryable();
            bannersQuery = bannersQuery.Where(d => d.IsDelete == filter.IsDelete);
            bannersQuery = bannersQuery.Where(d => d.IsSelected == filter.IsSelected);

            var count = (int)Math.Ceiling(bannersQuery.Count() / (double)filter.TakeEntity);
            var pager = Pager.Build(count, filter.PageId, filter.TakeEntity);
            var banners = await bannersQuery.Paging(pager).ToListAsync();
            return filter.SetPaging(pager).SetBanners(banners);
        }

    }
}
