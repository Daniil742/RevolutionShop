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
	public class ProductRepository : IDataModel<Product>
	{
		private readonly RevolutionShopDbContext _context;

		public ProductRepository(RevolutionShopDbContext context)
		{
			_context = context;
		}

		public List<Product> GetAllProductsByType(int id)
		{
			return _context.Products
				.Where(x => x.Id == id)
				.ToList();
		}

		public List<Product> GetAllProductsWithDiscount()
		{
			return _context.Products
				.Where(x => x.Discount != 0)
				.ToList();
		}

		public List<Product> GetAll()
		{
			return _context.Products.ToList();
		}

		public Product Get(int id)
		{
			return _context.Products.FirstOrDefault(x => x.Id == id);
		}

		public void AddProduct(Product product)
		{
			_context.Products.Add(product);
			_context.SaveChanges();
		}

		public void EditProduct(Product product)
		{
			_context.Products.Update(product);
			_context.SaveChanges();
		}

		public void DeleteById(int id)
		{
			var product = _context.Products.FirstOrDefault(x => x.Id == id);
			_context.Products.Remove(product);
			_context.SaveChanges();
		}
	}
}
