using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RevolutionShopWebApp.Models.Entities;

namespace RevolutionShopWebApp.Models.DB
{
	public class AppDbContext : IdentityDbContext<User>
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{
			Database.EnsureCreated();
		}
	}
}
