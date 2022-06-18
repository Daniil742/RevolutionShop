using Microsoft.AspNetCore.Identity;
using RevolutionData.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.Models.DB
{
	public class RoleInitializer
	{
		public static async Task Initialize(UserManager<Account> userManager, RoleManager<IdentityRole> roleManager)
		{
			string adminEmail = "admin@yandex.ru";
			string password = "1234Dd/";

			if (await roleManager.FindByNameAsync("Admin") == null)
			{
				await roleManager.CreateAsync(new IdentityRole("Admin"));
			}

			if (await roleManager.FindByNameAsync("User") == null)
			{
				await roleManager.CreateAsync(new IdentityRole("User"));
			}

			if (await roleManager.FindByNameAsync("Moderator") == null)
			{
				await roleManager.CreateAsync(new IdentityRole("Moderator"));
			}

			if (await userManager.FindByNameAsync(adminEmail) == null)
			{
				var admin = new Account
				{
					Email = adminEmail,
					UserName = adminEmail
				};

				var result = await userManager.CreateAsync(admin, password);

				if (result.Succeeded)
				{
					await userManager.AddToRoleAsync(admin, "Admin");
				}
			}
		}
	}
}
