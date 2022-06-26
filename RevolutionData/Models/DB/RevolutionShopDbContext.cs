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
		/// Отражение таблицы БД Products на сойство DbSet.
		/// </summary>
		public DbSet<Product> Products { get; set; }

		/// <summary>
		/// Отражение таблицы БД ProductTypes на свойство DbSet.
		/// </summary>
		public DbSet<ProductType> ProductTypes { get; set; }

		/// <summary>
		/// Отражение таблицы БД ProductSizes на свойство DbSet.
		/// </summary>
		public DbSet<ProductSize> ProductSizes { get; set; }

		public DbSet<Order> Orders { get; set; }

		/// <summary>
		/// Добавление настроек конфигурации.
		/// </summary>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().ToTable("Product_Table");
			modelBuilder.Entity<ProductType>().ToTable("ProductType_Table");
			modelBuilder.Entity<ProductSize>().ToTable("ProductSize_Table");
			modelBuilder.Entity<Order>().ToTable("Order_Table");
			base.OnModelCreating(modelBuilder);
		}
	}
}
