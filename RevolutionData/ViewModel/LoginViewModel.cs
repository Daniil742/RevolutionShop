using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.ViewModel
{
	public class LoginViewModel
	{
		/// <summary>
		/// Почтовый адрес для входа.
		/// </summary>
		[Required]
		[Display(Name = "Email")]
		public string Email { get; set; }
		/// <summary>
		/// Пароль аккаунта.
		/// </summary>
		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "Пароль")]
		public string Password { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "Запомнить?")]
		public bool RememberMe { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string ReturnUrl { get; set; }
	}
}
