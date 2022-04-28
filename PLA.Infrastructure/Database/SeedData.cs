namespace PLA.Infrastructure.Database
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class SeedData
    {
        public static void MigrateContexts(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var baseDbContext = scope.ServiceProvider.GetRequiredService<BaseDbContext>();
            try
            {
                baseDbContext.Database.Migrate();
            }
            catch (Exception)
            {
            }
        }
    }
}