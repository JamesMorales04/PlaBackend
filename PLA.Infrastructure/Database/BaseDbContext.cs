namespace PLA.Infrastructure.Database
{
    using Microsoft.EntityFrameworkCore;
    using PLA.Domain.Crop.Models;
    using PLA.Domain.Inventory.Models;
    using PLA.Domain.Plots.Models;

    public class BaseDbContext : DbContext
    {
        public BaseDbContext()
        {
        }

        public BaseDbContext(DbContextOptions<BaseDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Plot> Plot { get; set; }

        public virtual DbSet<Crop> Crop { get; set; }

        public virtual DbSet<Inventory> Inventory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}