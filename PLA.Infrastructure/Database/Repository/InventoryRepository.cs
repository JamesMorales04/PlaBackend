namespace PLA.Infrastructure.Database.Repository
{
    using PLA.Domain.Inventory.Models;
    using PLA.Domain.Inventory.Repository;

    public class InventoryRepository : Repository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(BaseDbContext coexDbContext)
            : base(coexDbContext)
        {
        }

        public Inventory? GetProductById(Guid id)
        {
            return GetAll().FirstOrDefault(x => x.InvetoryId == id);
        }
    }
}