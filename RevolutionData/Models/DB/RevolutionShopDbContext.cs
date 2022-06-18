using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RevolutionData.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.Models.DB
{
	public class RevolutionShopDbContext : IdentityDbContext<Account>
	{
		public RevolutionShopDbContext(DbContextOptions<RevolutionShopDbContext> options)
			: base(options) => SimpleDbInitializer.Initialize(this);

		/// <summary>
		/// Отражение талицы БД TShirts на свойство DbSet.
		/// </summary>
		public DbSet<TShirt> TShirts { get; set; }

		/// <summary>
		/// Отражение талицы БД Shoppers на свойство DbSet.
		/// </summary>
		public DbSet<Shopper> Shoppers { get; set; }

		/// <summary>
		/// Добавление настроек конфигурации.
		/// </summary>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<TShirt>().ToTable("TShirt_Table");
			modelBuilder.Entity<Shopper>().ToTable("Shopper_Table");
			base.OnModelCreating(modelBuilder);
		}
	}
}
