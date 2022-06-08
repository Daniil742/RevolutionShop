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
			context.Database.EnsureCreated();

			if (!context.TShirts.Any())
			{
				context.TShirts.AddRange(new List<TShirt>
				{
					new TShirt
					{
						Name = "TestName1",
						Price = 1000M,
						Size = "XL",
						Count = 100,
						Description = "100% хлопок"
					},
					new TShirt
					{
						Name = "TestName2",
						Price = 9M,
						Size = "S",
						Count = 9,
						Description = "99% хлопок, 1% полиэстер"
					}
				});

				context.SaveChanges();
			}
		}
	}
}
