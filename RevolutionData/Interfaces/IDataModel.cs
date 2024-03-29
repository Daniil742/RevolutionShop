﻿using RevolutionData.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.Interfaces
{
	public interface IDataModel<T> where T : class
	{
		List<T> GetAllProductsByType(int id);
		List<T> GetAllProductsWithDiscount();
		List<T> GetAll();
		void AddProduct(T product);
		void EditProduct(T product);
		void DeleteById(int id);
		T Get(int id);
	}
}