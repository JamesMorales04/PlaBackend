namespace PLA.Domain.Plots.Repository
{
    using PLA.Domain.Plots.Models;
    using PLA.Domain.Shared.Repository;

    public interface IPlotRepository : IRepository<Plot>
    {
        public Plot? GetPlotById(Guid id);
    }
}