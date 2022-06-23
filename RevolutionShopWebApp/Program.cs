using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RevolutionData.Interfaces;
using RevolutionData.Models;
using RevolutionData.Models.DB;
using RevolutionData.Models.Entities;
using RevolutionData.Models.Repositories;


var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<RevolutionShopDbContext>(options => options.UseSqlServer(connection));
builder.Services.AddIdentity<Account, IdentityRole>()
    .AddEntityFrameworkStores<RevolutionShopDbContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddMvc();
builder.Services.AddSession();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseSession();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();