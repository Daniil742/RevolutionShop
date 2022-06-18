using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RevolutionData.Interfaces;
using RevolutionData.Models;
using RevolutionData.Models.DB;
using RevolutionData.Models.Entities;
using RevolutionData.Models.Repositories;


var builder = WebApplication.CreateBuilder(args);

var identityConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<RevolutionShopDbContext>(options => options.UseSqlServer(identityConnection));
builder.Services.AddIdentity<Account, IdentityRole>()
    .AddEntityFrameworkStores<RevolutionShopDbContext>();

//var connection = builder.Configuration.GetConnectionString("DefaultConnection");

//builder.Services.AddDbContext<RevolutionShopDbContext>(options => options.UseSqlServer(connection));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddMvc();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();