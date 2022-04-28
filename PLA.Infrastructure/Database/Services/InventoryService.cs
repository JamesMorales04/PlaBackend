namespace PLA.Infrastructure.Database.Services
{
    using PLA.Domain.Inventory.Models;
    using PLA.Domain.Inventory.Repository;
    using PLA.Domain.Inventory.Service;

    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryService(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository ?? throw new ArgumentNullException(nameof(inventoryRepository));
        }

        public Inventory GetProductById(Guid id)
        {
            return _inventoryRepository.GetProductById(id) ?? throw new NullReferenceException(nameof(GetProductById));
        }

        public IQueryable<Inventory> GetAllProducts(int page, int size)
        {
            return _inventoryRepository.GetAll(page, size);
        }
    }
}