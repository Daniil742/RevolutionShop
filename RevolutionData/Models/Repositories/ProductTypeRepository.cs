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
	public class ProductTypeRepository : IDataModel<ProductType>
	{
		private readonly RevolutionShopDbContext _context;

		public ProductTypeRepository(RevolutionShopDbContext context)
		{
			_context = context;
		}

		public List<ProductType> GetAllProductsByType(int id)
		{
			return _context.ProductTypes
				.Where(x => x.Id == id)
				.ToList();
		}

		public List<ProductType> GetAllProductsWithDiscount()
		{
			throw new NotImplementedException();
		}

		public List<ProductType> GetAll()
		{
			return _context.ProductTypes.ToList();
		}

		public ProductType Get(int id)
		{
			return _context.ProductTypes.FirstOrDefault(x => x.Id == id);
		}
	}
}
