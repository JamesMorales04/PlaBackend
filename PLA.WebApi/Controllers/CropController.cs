namespace PLA.Workshop.WebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PLA.Domain.Crop.Models;
    using PLA.Domain.Crop.Services;

    [Route("api/v1/[controller]")]
    [ApiController]
    public class CropController : ControllerBase
    {
        private readonly IICropService _cropsService;

        public CropController(IICropService cropsService)
        {
            _cropsService = cropsService ?? throw new ArgumentNullException(nameof(cropsService));
        }

        [HttpGet]
        public ActionResult<List<Crop>> GetAllCrops(int page, int size)
        {
            try
            {
                var crops = _cropsService.GetAllCrops(page, size);
                return Ok(crops);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet("/GetCropById")]
        public ActionResult<Crop> GetCropById(Guid id)
        {
            try
            {
                var crops = _cropsService.GetCropByIdAsync(id);
                return Ok(crops);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<Crop> CreateCrop(Crop crop)
        {
            try
            {
                var crops = _cropsService.AddCropAsync(crop);
                return Ok(crops);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}