using Microsoft.AspNetCore.Mvc;

namespace RevolutionShopWebApp.Controllers
{
	public class AccountController : Controller
	{
		/// <summary>
		/// Личный кабинет.
		/// </summary>
		/// <returns> Страница с входом или регистрацией, если пользователь не авторизован. </returns>
		public IActionResult AccountPage()
		{
			return View();
		}
	}
}
