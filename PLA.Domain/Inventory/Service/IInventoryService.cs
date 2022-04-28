namespace PLA.Domain.Inventory.Service
{
    using PLA.Domain.Inventory.Models;

    public interface IInventoryService
    {
        public Inventory GetProductById(Guid id);

        public IQueryable<Inventory> GetAllProducts(int page, int size);
    }
}