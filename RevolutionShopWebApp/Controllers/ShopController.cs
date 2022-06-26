using Microsoft.AspNetCore.Mvc;
using RevolutionData.Interfaces;
using RevolutionData.Models.Entities;
using RevolutionData.Models.Repositories;

namespace RevolutionShopWebApp.Controllers
{
	public class ShopController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;

		public ShopController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public IActionResult ProductPage(int id)
		{
			List<Product> products;
			if (id == 0)
			{
				products = _unitOfWork.Products.GetAllProductsWithDiscount();
			}
			else
			{
				products = _unitOfWork.Products.GetAllProductsByType(id);
			}
			return View(products);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public IActionResult ProductDetailPage(int id)
		{
			var product = _unitOfWork.Products.Get(id);
			return View(product);
		}
	}
}
