using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RevolutionData.ViewModel;
using RevolutionShopWebApp.Models.Entities;

namespace RevolutionShopWebApp.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<User> _userManager;
		private readonly SignInManager<User> _signInManager;

		public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		[HttpGet]
		public IActionResult RegistrationPage()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> RegistrationPage(RegisterViewModel model)
		{
			if (ModelState.IsValid)
			{
				User user = new User
				{
					UserName = model.UserName,
					Email = model.Email
				};

				var result = await _userManager.CreateAsync(user, model.Password);

				if (result.Succeeded)
				{
					await _signInManager.SignInAsync(user, false);
					return RedirectToAction("Index", "Home");
				}
				else
				{
					foreach (var error in result.Errors)
					{
						ModelState.AddModelError(string.Empty, error.Description);
					}
				}
			}
			return View(model);
		}

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
		//public IActionResult RegistrationPage()
		//{
		//	return View();
		//}

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
