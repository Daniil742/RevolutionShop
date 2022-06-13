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
		/// Футболки.
		/// </summary>
		/// <returns> Страница с товарами категории "Футболки". </returns>
		public IActionResult TShirtPage()
		{
			var tShirts = _unitOfWork.TShirts.GetAll();
			return View(tShirts);
		}

		/// <summary>
		/// Лонгсливы.
		/// </summary>
		/// <returns> Страница с товарами категории "Лонгсливы". </returns>
		public IActionResult LongsleevePage()
		{
			return View();
		}

		/// <summary>
		/// Худи.
		/// </summary>
		/// <returns> Страница с товарами категории "Худи". </returns>
		public IActionResult HoodiePage()
		{
			return View();
		}

		/// <summary>
		/// Головные уборы.
		/// </summary>
		/// <returns> Страница с товарами категории "Головные уборы". </returns>
		public IActionResult HeaddressPage()
		{
			return View();
		}

		/// <summary>
		/// Штаны и шорты.
		/// </summary>
		/// <returns> Страница с товарами категории "Брюки и шорты". </returns>
		public IActionResult PantAndShortPage()
		{
			return View();
		}

		/// <summary>
		/// Шопперы.
		/// </summary>
		/// <returns> Страница с товарами категории "Шопперы". </returns>
		public IActionResult ShopperPage()
		{
			return View();
		}

		/// <summary>
		/// Конкретный товар.
		/// </summary>
		/// <returns> Страница с подробной инфомацией о товаре. </returns>
		public IActionResult ProductPage(int id)
		{
			var product = _unitOfWork.TShirts.Get(id);
			return View(product);
		}
	}
}
