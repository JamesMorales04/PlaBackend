namespace PLA.Domain.Crop.Services
{
    using PLA.Domain.Crop.Models;

    public interface IICropService
    {
        public Task<Crop> GetCropByIdAsync(Guid id);

        public IQueryable<Crop> GetAllCrops(int page, int size);

        public Task<Crop> AddCropAsync(Crop product);
    }
}