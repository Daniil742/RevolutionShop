using RevolutionData.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		IDataModel<Product> Products { get; }
		IDataModel<ProductType> ProductTypes { get; }
		void Save();
	}
}
