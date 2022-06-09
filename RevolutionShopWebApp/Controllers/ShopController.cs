using Microsoft.AspNetCore.Mvc;
using RevolutionData.Interfaces;
using RevolutionData.Models.Entities;

namespace RevolutionShopWebApp.Controllers
{
	public class ShopController : Controller
	{
		private readonly IDataModel _dataModel;

		public ShopController(IDataModel dataModel)
		{
			_dataModel = dataModel;
		}

		/// <summary>
		/// Футболки.
		/// </summary>
		/// <returns> Страница с товарами категории "Футболки". </returns>
		public IActionResult TShirtPage()
		{
			return View(_dataModel.GetAll());
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
			var product = _dataModel.Get(id);
			return View(product);
		}
	}
}
