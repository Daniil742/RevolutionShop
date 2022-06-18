using RevolutionData.Interfaces;
using RevolutionData.Models.DB;
using RevolutionData.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.Models.Repositories
{
	public class ShopperRepository : IDataModel<Shopper>
	{
		private readonly RevolutionShopDbContext _context;

		public ShopperRepository(RevolutionShopDbContext context)
		{
			_context = context;
		}

		public List<Shopper> GetAll()
		{
			return _context.Shoppers.ToList();
		}

		public Shopper Get(int id)
		{
			return _context.Shoppers.FirstOrDefault(x => x.Id == id);
		}
	}
}
