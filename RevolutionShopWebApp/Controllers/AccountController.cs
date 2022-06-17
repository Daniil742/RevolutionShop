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

		/// <summary>
		/// Регистрация.
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		public IActionResult RegistrationPage()
		{
			return View();
		}

		/// <summary>
		/// Регистрация.
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
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
		/// Авторизация.
		/// </summary>
		/// <returns> Страница авторизации. </returns>
		[HttpGet]
		public IActionResult AuthorizationPage(string returnUrl = "")
		{
			return View(new LoginViewModel { ReturnUrl = returnUrl });
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AuthorizationPage(LoginViewModel model)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

				if (result.Succeeded)
				{
					if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
					{
						return Redirect(model.ReturnUrl);
					}
					else
					{
						return RedirectToAction("AuthorizationPage", "Account");
					}
				}
				else
				{
					ModelState.AddModelError("", "Неправильный логин или пароль");
				}
			}

			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}
	}
}
