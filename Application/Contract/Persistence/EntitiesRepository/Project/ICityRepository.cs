using Application.Contract.Persistence.CommonGenericRepository;
using Domain.Entities.Project;
using System;

namespace Application.Contract.Persistance.EntitiesRepository.Project
{
    public interface ICityRepository : IDisposable, IGenericRepository<City>
    {
    }
}
