namespace PLA.Domain.Crop.Respository
{
    using PLA.Domain.Crop.Models;
    using PLA.Domain.Shared.Repository;

    public interface ICropRepository : IRepository<Crop>
    {
        Task<Crop?> GetCropByIdAsync(Guid id);
    }
}