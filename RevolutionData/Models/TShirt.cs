using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.Models
{
	/// <summary>
	/// Футблка.
	/// </summary>
	internal class TShirt
	{
		/// <summary>
		/// Id.
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Название.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Цена.
		/// </summary>
		public decimal Price { get; set; }
		/// <summary>
		/// Скидка, может содержать значение null.
		/// </summary>
		public int? Discount { get; set; }
		/// <summary>
		/// Размер.
		/// </summary>
		public string Size { get; set; }
		/// <summary>
		/// Количество.
		/// </summary>
		public int Count { get; set; }
		/// <summary>
		/// Описание торава.
		/// </summary>
		public string Description { get; set; }
	}
}
