namespace PLA.Infrastructure.Database
{
    using PLA.Domain.Shared.Repository;

    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, new()
    {
        private readonly BaseDbContext _dbContext;

        public Repository(BaseDbContext coexDbContext)
        {
            _dbContext = coexDbContext ?? throw new ArgumentNullException(nameof(coexDbContext));
        }

        public IQueryable<TEntity> GetAll(int page, int size)
        {
            if (page <= 0 || size <= 0)
            {
                page = 1;
                size = 1;
            }

            try
            {
                return _dbContext.Set<TEntity>().Skip((page - 1) * size).Take(size);
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return _dbContext.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new InvalidDataException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                _dbContext.Add(entity);
                _dbContext.SaveChanges();

                return entity;
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"{nameof(entity)} could not be saved: {ex.InnerException}");
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new InvalidDataException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                _dbContext.Update(entity);
                await _dbContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }
    }
}