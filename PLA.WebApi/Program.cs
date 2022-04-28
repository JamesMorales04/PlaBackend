using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PLA.Domain.Crop.Respository;
using PLA.Domain.Crop.Services;
using PLA.Domain.Inventory.Repository;
using PLA.Domain.Inventory.Service;
using PLA.Domain.Plots.Repository;
using PLA.Domain.Plots.Service;
using PLA.Domain.Shared.Repository;
using PLA.Infrastructure.Database;
using PLA.Infrastructure.Database.Repository;
using PLA.Infrastructure.Database.Services;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var MyAllowAllOrigins = "_myAllowSpecificOrigins";

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowAllOrigins,
                      policy =>
                      {
                          policy.AllowAnyOrigin();
                      });
});
builder.Services.AddSwaggerGen();
var dbConnectionString = @builder.Configuration.GetValue<string>("Database:ConnectionString");
builder.Services.AddDbContext<BaseDbContext>(options => options.UseMySql(dbConnectionString, ServerVersion.AutoDetect(dbConnectionString)));
builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient<IInventoryRepository, InventoryRepository>();
builder.Services.AddTransient<IPlotRepository, PlotRepository>();
builder.Services.AddTransient<ICropRepository, CropRepository>();
builder.Services.AddTransient<IInventoryService, InventoryService>();
builder.Services.AddTransient<IPlotService, PlotService>();
builder.Services.AddTransient<IICropService, CropService>();
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

app.UseSwagger();
app.UseCors(MyAllowAllOrigins);
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
SeedData.MigrateContexts(app.Services);

app.Run();