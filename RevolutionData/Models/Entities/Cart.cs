using Microsoft.AspNetCore.Http;
using RevolutionData.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.Models.Entities
{
	public class Cart
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public string? ProductName { get; set; }
		public decimal? ProductPrice { get; set; }
		public int Quantity { get; set; }
		public virtual Account Account { get; set; }

	}
}
