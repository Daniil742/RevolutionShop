using Microsoft.AspNetCore.Mvc;
using RevolutionData.Interfaces;
using RevolutionData.Models.Entities;

namespace RevolutionShopWebApp.Controllers
{
	public class AdminController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;

		public AdminController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public IActionResult Index()
		{
			var products = _unitOfWork.Products.GetAll();
			return View(products);
		}

		public IActionResult AddProduct()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> AddProduct(Product product)
		{
			_unitOfWork.Products.AddProduct(product);
			return RedirectToAction("Index");
		}

		public IActionResult EditProduct(int id)
		{
			if (id != 0)
			{
				var product = _unitOfWork.Products.Get(id);
				return View(product);
			}
			return NotFound();
		}

		[HttpPost]
		public IActionResult EditProduct(Product product)
		{
			_unitOfWork.Products.EditProduct(product);
			return RedirectToAction("Index");
		}

		[HttpPost]
		public async Task<IActionResult> DeleteProduct(int id)
		{
			if (id != 0)
			{
				_unitOfWork.Products.DeleteById(id);
				return RedirectToAction("Index");
			}

			return NotFound();
		}
	}
}
