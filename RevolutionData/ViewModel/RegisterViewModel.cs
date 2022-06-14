using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.ViewModel
{
	public class RegisterViewModel
	{
		/// <summary>
		/// Имя.
		/// </summary>
		[Required]
		[Display(Name = "Имя")]
		public string UserName { get; set; }
		/// <summary>
		/// Почтовый адрес для рассылки.
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
		/// Подтверждение пароля.
		/// </summary>
		[Required]
		[Compare("Password", ErrorMessage = "Пароли не совпадают")]
		[DataType(DataType.Password)]
		[Display(Name = "Пароль")]
		public string PasswordConfirm { get; set; }
		/// <summary>
		/// Подтверждение адреса електронной почты.
		/// </summary>
		//[Required]
		//[Display(Name = "Email")]
		//public bool EmailConfirmed { get; set; } = false;
	}
}
