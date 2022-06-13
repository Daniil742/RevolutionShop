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
		IEnumerable<T> GetAll();

		T Get(int id);
	}
}