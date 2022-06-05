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

		/// <summary>
		/// Регистрация.
		/// </summary>
		/// <returns> Страница регистрации. </returns>
		public IActionResult RegistrationPage()
		{
			return View();
		}

		/// <summary>
		/// Авторизация.
		/// </summary>
		/// <returns> Страница авторизации. </returns>
		public IActionResult AuthorizationPage()
		{
			return View();
		}
	}
}
