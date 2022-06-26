using RevolutionData.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.Models.DB
{
	public static class SimpleDbInitializer
	{
		public static void Initialize(RevolutionShopDbContext context)
		{
			//context.Database.EnsureDeleted();
			context.Database.EnsureCreated();

			if (!context.ProductTypes.Any())
			{
				context.ProductTypes.AddRange(new List<ProductType>
				{
					new ProductType
					{
						Name = "Футболки"
					},
					new ProductType
					{
						Name = "Лонгсливы"
					},new ProductType
					{
						Name = "Худи и свитшоты"
					},
					new ProductType
					{
						Name = "Брюки и шорты"
					},
					new ProductType
					{
						Name = "Головные уборы"
					},
					new ProductType
					{
						Name = "Шоперы"
					}
				});

				context.SaveChanges();
			}

			if (!context.Products.Any())
			{
				context.Products.AddRange(new List<Product>
				{
					new Product
					{
						TypeId = 1,
						Name = "NewTestName1",
						Price = 1000.00M,
						Discount = 23,
						Count = 100,
						Description = "100% хлопок"
					},
					new Product
					{
						TypeId = 2,
						Name = "NewTestName2",
						Price = 1000.00M,
						Discount = 23,
						Count = 100,
						Description = "100% хлопок"
					},
					new Product
					{
						TypeId = 3,
						Name = "NewTestName3",
						Price = 1000.00M,
						Discount = 23,
						Count = 100,
						Description = "100% хлопок"
					},
					new Product
					{
						TypeId = 4,
						Name = "NewTestName4",
						Price = 1000.00M,
						Discount = 23,
						Count = 100,
						Description = "100% хлопок"
					},
					new Product
					{
						TypeId = 5,
						Name = "NewTestName5",
						Price = 1000.00M,
						Discount = 23,
						Count = 100,
						Description = "100% хлопок"
					},
					new Product
					{
						TypeId = 6,
						Name = "NewTestName6",
						Price = 1000.00M,
						Discount = 23,
						Count = 100,
						Description = "100% хлопок"
					}
				});

				context.SaveChanges();
			}

			if (!context.ProductSizes.Any())
			{
				context.ProductSizes.AddRange(new List<ProductSize>
				{
					new ProductSize
					{
						Name = "S"
					},
					new ProductSize
					{
						Name = "M"
					},new ProductSize
					{
						Name = "L"
					},
					new ProductSize
					{
						Name = "XL"
					}
				});
				context.SaveChanges();
			}
		}
	}
}
