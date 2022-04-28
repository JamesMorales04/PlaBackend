namespace PLA.Infrastructure.Database.Services
{
    using PLA.Domain.Crop.Models;
    using PLA.Domain.Crop.Respository;
    using PLA.Domain.Crop.Services;

    public class CropService : IICropService
    {
        private readonly ICropRepository _cropRepository;

        public CropService(ICropRepository cropRepository)
        {
            _cropRepository = cropRepository ?? throw new ArgumentNullException(nameof(cropRepository));
        }

        public async Task<Crop> GetCropByIdAsync(Guid id)
        {
            return await _cropRepository.GetCropByIdAsync(id) ?? throw new NullReferenceException(nameof(GetCropByIdAsync));
        }

        public IQueryable<Crop> GetAllCrops(int page, int size)
        {
            return _cropRepository.GetAll(page, size);
        }

        public Task<Crop> AddCropAsync(Crop product)
        {
            return _cropRepository.AddAsync(product) ?? throw new NullReferenceException(nameof(AddCropAsync));
        }
    }
}