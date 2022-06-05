using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.Models
{
	/// <summary>
	/// Аккаунт.
	/// </summary>
	internal class Account
	{
		/// <summary>
		/// Id аккаунта.
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Имя.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Почтовый адрес для рассылки.
		/// </summary>
		public string Email { get; set; }
		/// <summary>
		/// Пароль аккаунта.
		/// </summary>
		public string Password { get; set; }
		/// <summary>
		/// Включение подписки на рассылку.
		/// </summary>
		public bool IsMailing { get; set; } = false;
	}
}
