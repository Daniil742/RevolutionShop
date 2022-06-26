using Microsoft.AspNetCore.Mvc;
using RevolutionData.Interfaces;

namespace RevolutionShopWebApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;

		public HomeController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		/// <summary>
		/// Главная.
		/// </summary>
		/// <returns> Главная страница магазина. </returns>
		public IActionResult Index()
		{
			var type = _unitOfWork.ProductTypes.GetAll();
			return View(type);
		}

		/// <summary>
		/// Магазин.
		/// </summary>
		/// <returns></returns>
		public IActionResult Shop()
		{
			return View();
		}

		/// <summary>
		/// Лукбук.
		/// </summary>
		/// <returns> Страница с лукбуком. </returns>
		public IActionResult LookBook()
		{
			return View();
		}

		/// <summary>
		/// Скидки.
		/// </summary>
		/// <returns> Страница товаров со скидками. </returns>
		public IActionResult Sale()
		{
			return View();
		}

		/// <summary>
		/// Доставка и оплата.
		/// </summary>
		/// <returns> Страница с информацией о доставке и оплате. </returns>
		public IActionResult DeliveryAndPayment()
		{
			return View();
		}

		/// <summary>
		/// Контакты.
		/// </summary>
		/// <returns> Страница с контактной информацией магазина. </returns>
		public IActionResult Contact()
		{
			return View();
		}
	}
}
