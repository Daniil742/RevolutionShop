using Microsoft.AspNetCore.Mvc;

namespace RevolutionShopWebApp.Controllers
{
	public class ShopController : Controller
	{
		/// <summary>
		/// Футболки.
		/// </summary>
		/// <returns> Страница с товарами категории "Футболки". </returns>
		public IActionResult TShirtPage()
		{
			return View();
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
	}
}
