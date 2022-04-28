namespace PLA.Infrastructure.Database.Repository
{
    using Microsoft.EntityFrameworkCore;
    using PLA.Domain.Crop.Models;
    using PLA.Domain.Crop.Respository;

    public class CropRepository : Repository<Crop>, ICropRepository
    {
        public CropRepository(BaseDbContext coexDbContext)
            : base(coexDbContext)
        {
        }

        public Task<Crop?> GetCropByIdAsync(Guid id)
        {
            return GetAll().FirstOrDefaultAsync(x => x.CropId == id);
        }
    }
}