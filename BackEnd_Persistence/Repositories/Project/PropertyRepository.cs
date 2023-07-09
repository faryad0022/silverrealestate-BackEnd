using Application.Contract.Persistance.EntitiesRepository.Project;
using Application.DTOs.Paging;
using Application.Extensions;
using Application.Models.FilterModels;
using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Persistence.Repositories.Project
{
    public class PropertyRepository : GenericRepository<Property>, IPropertyRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public PropertyRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<FilterProperty> FilterProperty(FilterProperty filter)
        {
            var propertyQuery = GetEntitiesQuery()
                .Include(x => x.City)
                .Include(x => x.PropertyTypes)
                .Include(x => x.PropertyContractType)
                .AsQueryable();
            if (filter.NumberOfBathroom > 0)
            {
                propertyQuery = propertyQuery.Where(x => x.NumberOfBathroom <= filter.NumberOfBathroom);
            }
            if (filter.NumberOfBedroom > 0)
            {
                propertyQuery = propertyQuery.Where(x => x.NumberOfBedroom <= filter.NumberOfBedroom);
            }
            if (filter.FloorSpace > 0)
            {
                propertyQuery = propertyQuery.Where(x => x.FloorSpace <= filter.FloorSpace);
            }
            if (filter.MinPrice > 0)
            {
                propertyQuery = propertyQuery.Where(x => x.Price >= filter.MinPrice);
            }
            if (filter.MaxPrice > 0)
            {
                propertyQuery = propertyQuery.Where(x => x.Price <= filter.MaxPrice);
            }
            if (filter.CityId > 0)
            {
                propertyQuery = propertyQuery.Where(x => x.CityId == filter.CityId);
            }
            if (filter.PropertyContractTypeId > 0)
            {
                propertyQuery = propertyQuery.Where(x => x.PropertyContractTypeId == filter.PropertyContractTypeId);
            }
            if (filter.PropertyTypeId > 0)
            {
                propertyQuery = propertyQuery.Where(x => x.PropertyTypeId == filter.PropertyTypeId);
            }
            propertyQuery = propertyQuery.Where(x => x.PropertyStatus == filter.PropertyStatus);

            var count = (int)Math.Ceiling(propertyQuery.Count() / (double)filter.TakeEntity);
            var pager = Pager.Build(count, filter.PageId, filter.TakeEntity);
            var properties = await propertyQuery.Paging(pager).ToListAsync();
            return filter.SetPaging(pager).SetProperties(properties);
        }

        public async Task<List<Property>> GetPropertyListWithDetails()
        {
            return await _dbContext.Properties
               .Include(x => x.City)
               .Include(x => x.PropertyTypes)
               .Include(x => x.PropertyContractType).ToListAsync();
        }

        public async Task<Property> GetPropertyWithDetails(long id)
        {
            return await _dbContext.Properties
               .Include(x => x.City)
               .Include(x => x.PropertyTypes)
               .Include(x => x.PropertyContractType)
               .SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}
