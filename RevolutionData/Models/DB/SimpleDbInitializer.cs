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
			context.Database.EnsureDeleted();
			context.Database.EnsureCreated();

			if (!context.TShirts.Any())
			{
				context.TShirts.AddRange(new List<TShirt>
				{
					new TShirt
					{
						Name = "TestName1",
						Price = 1000.00M,
						Discount = 23,
						Size = "XL",
						Count = 100,
						Description = "100% хлопок"
					},
					new TShirt
					{
						Name = "TestName2",
						Price = 9.00M,
						Discount = 0,
						Size = "S",
						Count = 9,
						Description = "99% хлопок, 1% полиэстер"
					},
					new TShirt
					{
						Name = "TestName3",
						Price = 79.00M,
						Discount = 0,
						Size = "M",
						Count = 0,
						Description = "79% хлопок, 21% полиэстер"
					},
					new TShirt
					{
						Name = "TestName4",
						Price = 59.00M,
						Discount = 0,
						Size = "M",
						Count = 29,
						Description = "79% хлопок, 21% полиэстер"
					},
					new TShirt
					{
						Name = "TestName5",
						Price = 39.00M,
						Discount = 0,
						Size = "M",
						Count = 29,
						Description = "79% хлопок, 21% полиэстер"
					}
				});

				context.SaveChanges();
			}
		}
	}
}
