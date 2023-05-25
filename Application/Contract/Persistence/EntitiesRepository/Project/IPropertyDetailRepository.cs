using Application.Contract.Persistence.CommonGenericRepository;
using Domain.Entities.Project;
using System;

namespace Application.Persistance.Contract.EntitiesRepository.Project
{
    public interface IPropertyDetailRepository : IDisposable, IGenericRepository<PropertyFacility>
    {
    }
}
