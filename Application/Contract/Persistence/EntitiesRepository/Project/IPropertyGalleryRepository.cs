using Application.Contract.Persistence.CommonGenericRepository;
using Domain.Entities.Project;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.Persistance.EntitiesRepository.Project
{
    public interface IPropertyGalleryRepository : IDisposable, IGenericRepository<PropertyFacility >
    {
    }
}
