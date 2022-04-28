namespace PLA.Domain.Shared.Repository
{
    public interface IRepository<TEntity>
        where TEntity : class, new()
    {
        IQueryable<TEntity> GetAll(int page, int size);

        IQueryable<TEntity> GetAll();

        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);
    }
}