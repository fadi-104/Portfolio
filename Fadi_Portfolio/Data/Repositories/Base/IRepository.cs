namespace Fadi_Portfolio.Data.Repositories.Base
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> QueryAllNoTracking();
        Task<List<TEntity>> GetAllNoTrackingAsync();
        Task<TEntity> FindAsync(int id);
        Task<TEntity> FindNoTrackingAsync(int id);
        Task<int> CountAsync();
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(TEntity entity);
    }
}
