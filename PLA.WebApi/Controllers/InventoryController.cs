namespace PLA.Workshop.WebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PLA.Domain.Inventory.Models;
    using PLA.Domain.Inventory.Service;

    [Route("api/v1/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _productService;

        public InventoryController(IInventoryService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        [HttpGet("/GetProductById")]
        public ActionResult<Inventory> GetProductById(Guid id)
        {
            try
            {
                var products = _productService.GetProductById(id);
                return Ok(products);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<Inventory>> GetAllProducts(int page, int size)
        {
            try
            {
                var products = _productService.GetAllProducts(page, size);
                return Ok(products);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}