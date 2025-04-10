using Fadi_Portfolio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fadi_Portfolio.Data.Repositories.Base
{
    public class GenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _dbCotext;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbCotext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> QueryAllNoTracking()
        {
            return _dbSet.AsNoTracking();
        }

        public virtual async Task<List<TEntity>> GetAllNoTrackingAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public virtual async Task<TEntity> FindAsync(int id)
        {
            var foundEntity = await _dbSet.FindAsync(id);
            return foundEntity;
        } 

        public virtual async Task<TEntity> FindNoTrackingAsync(int id)
        {
            var foundEntity = await _dbSet.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
            return foundEntity;
        }

        public virtual async Task<int> CountAsync()
        {
            return await _dbSet.CountAsync();
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            _dbSet.Add(entity);
            await _dbCotext.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            var updateEntity = _dbSet.Update(entity);
            updateEntity.State = EntityState.Modified;
            await _dbCotext.SaveChangesAsync();
        } 

        public virtual async Task<TEntity> DeleteAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
            await _dbCotext.SaveChangesAsync();
            return entity;

        }
    }
}
