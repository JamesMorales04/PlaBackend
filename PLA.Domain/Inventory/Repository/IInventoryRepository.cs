namespace PLA.Domain.Inventory.Repository
{
    using PLA.Domain.Inventory.Models;
    using PLA.Domain.Shared.Repository;

    public interface IInventoryRepository : IRepository<Inventory>
    {
        Inventory? GetProductById(Guid id);
    }
}