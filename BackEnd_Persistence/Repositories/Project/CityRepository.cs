using Application.Contract.Persistance.EntitiesRepository.Project;
using Domain.Entities.Project;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd_Persistence.Repositories.Project
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public CityRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
