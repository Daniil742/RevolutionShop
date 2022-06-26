using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.Models.Entities
{
	/// <summary>
	/// Товар для продажи.
	/// </summary>
	public class Product
	{
		/// <summary>
		/// Id товара.
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Тип товара.
		/// </summary>	
		public int TypeId { get; set; }
		/// <summary>
		/// Название товара.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Цена товара.
		/// </summary>
		public decimal Price { get; set; }
		/// <summary>
		/// Скидка на товар.
		/// </summary>
		public int Discount { get; set; }
		/// <summary>
		/// Размер товара.
		/// </summary>
		public int SizeId { get; set; }
		/// <summary>
		/// Количество товара.
		/// </summary>
		public int Count { get; set; }
		/// <summary>
		/// Описание товара.
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Id типа топара.
		/// </summary>
		//public int ProductTypeId { get; set; }
	}
}
