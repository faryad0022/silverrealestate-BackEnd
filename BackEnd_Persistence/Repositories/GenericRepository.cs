using Application.Contract.Persistence.CommonGenericRepository;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Persistence.Repositories
{

    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly RealEstateDbContext _dbContext;

        public GenericRepository(RealEstateDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public async Task<TEntity> AddEntityAsync(TEntity entity)
        {
            entity.CreateDate = DateTime.Now;
            await _dbContext.AddAsync(entity);
            return entity;

        }

        public void ChangeSelectedStatus(TEntity entity)
        {
            entity.IsSelected = !entity.IsSelected;
            entity.LastUpdateDate = DateTime.Now;
            _dbContext.Set<TEntity>().Update(entity);
        }

        public void DeleteEntity(TEntity entity)
        {
            entity.LastUpdateDate = DateTime.Now;
            entity.IsDelete = true;
            _dbContext.Set<TEntity>().Update(entity);

        }

        public async Task<bool> ExistAsync(long entityId)
        {
            var entity = await GetEntityAsync(entityId);
            return entity != null;
        }

        public async Task<IReadOnlyList<TEntity>> GetAllAsync()
        {
            return await _dbContext.Set<TEntity>().Where(t=>!t.IsDelete).ToListAsync();
        }

        public IQueryable<TEntity> GetEntitiesQuery()
        {
            return _dbContext.Set<TEntity>().AsQueryable();

        }

        public async Task<TEntity> GetEntityAsync(long entityId)
        {
            return await _dbContext.Set<TEntity>().FindAsync(entityId);
        }

        public void UpdateEntity(TEntity entity)
        {
            entity.LastUpdateDate = DateTime.Now;
            _dbContext.Set<TEntity>().Update(entity);
        }
    }
}
