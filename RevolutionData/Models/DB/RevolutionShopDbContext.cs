using Microsoft.EntityFrameworkCore;
using RevolutionData.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.Models.DB
{
	public class RevolutionShopDbContext : DbContext
	{
		public RevolutionShopDbContext(DbContextOptions<RevolutionShopDbContext> options)
			: base(options)
		{
			SimpleDbInitializer.Initialize(this);
		}

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
			modelBuilder.Entity<TShirt>(builder =>
			{
				builder.ToTable("TShirts");
				builder.HasKey(x => x.Id);
			});
		}
	}
}
