using Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Contract.Persistence.CommonGenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        
        IQueryable<TEntity> GetEntitiesQuery();
        Task<TEntity> GetEntityAsync(long entityId);
        Task<IReadOnlyList<TEntity>> GetAllAsync();
        Task<TEntity> AddEntityAsync(TEntity entity);
        void UpdateEntityAsync(TEntity entity);
        void ChangeSelectedStatusAsync(TEntity entity);
        void DeleteEntityAsync(TEntity entity);
        Task<bool> ExistAsync(long entityId);
    }
}
