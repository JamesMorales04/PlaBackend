namespace PLA.Workshop.WebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PLA.Domain.Plots.Models;
    using PLA.Domain.Plots.Service;

    [Route("api/v1/[controller]")]
    [ApiController]
    public class PlotController : ControllerBase
    {
        private readonly IPlotService _plotsService;

        public PlotController(IPlotService plotsService)
        {
            _plotsService = plotsService ?? throw new ArgumentNullException(nameof(plotsService));
        }

        [HttpGet]
        public ActionResult<List<Plot>> GetAllPlots(int page, int size)
        {
            try
            {
                var plots = _plotsService.GetAllPlots(page, size);
                return Ok(plots);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet("/GetPlotById")]
        public ActionResult<Plot> GetPlotById(Guid id)
        {
            try
            {
                var plots = _plotsService.GetPlotById(id);
                return Ok(plots);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}