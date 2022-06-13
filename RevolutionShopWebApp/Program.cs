using Microsoft.EntityFrameworkCore;
using RevolutionData.Interfaces;
using RevolutionData.Models;
using RevolutionData.Models.DB;
using RevolutionData.Models.Entities;
using RevolutionData.Models.Repositories;

var builder = WebApplication.CreateBuilder(args);
var connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<RevolutionShopDbContext>(options => options.UseSqlServer(connection));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddMvc();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseStaticFiles();

app.Run();