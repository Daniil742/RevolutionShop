﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RevolutionData.Models.Entities;
using RevolutionData.ViewModel;

namespace RevolutionShopWebApp.Controllers
{
	//[Authorize(Roles = "Admin")]
	public class RolesController : Controller
	{
		private RoleManager<IdentityRole> _roleManager;
		private UserManager<Account> _userManager;

		public RolesController(RoleManager<IdentityRole> roleManager, UserManager<Account> userManager)
		{
			_roleManager = roleManager;
			_userManager = userManager;
		}
		public IActionResult Index()
		{
			var roles = _roleManager.Roles.ToList();
			return View(roles);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(string name)
		{
			if (!string.IsNullOrEmpty(name))
			{
				var result = await _roleManager.CreateAsync(new IdentityRole(name));

				if (result.Succeeded)
				{
					return RedirectToAction("Index");
				}
				else
				{
					foreach (var error in result.Errors)
					{
						ModelState.AddModelError(string.Empty, error.Description);
					}
				}
			}

			return View(name);
		}

		[HttpPost]
		public async Task<IActionResult> Delete(string id)
		{
			var role = await _roleManager.FindByIdAsync(id);

			if (role != null)
			{
				var result = await _roleManager.DeleteAsync(role);
			}

			return RedirectToAction("Index");
		}

		public IActionResult UserList()
		{
			var users = _userManager.Users.ToList();
			return View(users);
		}

		public async Task<IActionResult> Edit(string userId)
		{
			var user = await _userManager.FindByIdAsync(userId);

			if (user != null)
			{
				var userRoles = await _userManager.GetRolesAsync(user);
				var allRoles = _roleManager.Roles.ToList();
				var model = new ChangeRoleViewModel
				{
					UserId = user.Id,
					UserEmail = user.Email,
					UserRoles = userRoles,
					AllRoles = allRoles
				};

				return View(model);
			}

			return NotFound();
		}

		[HttpPost]
		public async Task<IActionResult> Edit(string userId, List<string> roles)
		{
			var user = await _userManager.FindByIdAsync(userId);

			if (user != null)
			{
				var userRoles = await _userManager.GetRolesAsync(user);
				var allRoles = _roleManager.Roles.ToList();
				var addedRoles = roles.Except(userRoles);
				var removeRoles = userRoles.Except(roles);

				await _userManager.AddToRolesAsync(user, addedRoles);
				await _userManager.RemoveFromRolesAsync(user, removeRoles);

				return RedirectToAction("UserList");
			}

			return NotFound();
		}
	}
}
