namespace PLA.Infrastructure.Database.Services
{
    using PLA.Domain.Plots.Models;
    using PLA.Domain.Plots.Repository;
    using PLA.Domain.Plots.Service;

    public class PlotService : IPlotService
    {
        private readonly IPlotRepository _plotRepository;

        public PlotService(IPlotRepository plotRepository)
        {
            _plotRepository = plotRepository ?? throw new ArgumentNullException(nameof(plotRepository));
        }

        public Plot GetPlotById(Guid id)
        {
            return _plotRepository.GetPlotById(id) ?? throw new NullReferenceException(nameof(GetPlotById));
        }

        public IQueryable<Plot> GetAllPlots(int page, int size)
        {
            return _plotRepository.GetAll(page, size);
        }
    }
}