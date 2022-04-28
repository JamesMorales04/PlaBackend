namespace PLA.Infrastructure.Database.Repository
{
    using PLA.Domain.Plots.Models;
    using PLA.Domain.Plots.Repository;

    public class PlotRepository : Repository<Plot>, IPlotRepository
    {
        public PlotRepository(BaseDbContext coexDbContext)
            : base(coexDbContext)
        {
        }

        public Plot? GetPlotById(Guid id)
        {
            return GetAll().FirstOrDefault(x => x.PlotId == id);
        }
    }
}