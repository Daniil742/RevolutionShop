﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.Models.Entities
{
	public class CartItem
	{
		public TShirt TShirt { get; set; }
		public int Quantity { get; set; }
	}
}
