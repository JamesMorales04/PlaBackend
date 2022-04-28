namespace PLA.Domain.Plots.Service
{
    using PLA.Domain.Plots.Models;

    public interface IPlotService
    {
        public Plot GetPlotById(Guid id);

        public IQueryable<Plot> GetAllPlots(int page, int size);
    }
}