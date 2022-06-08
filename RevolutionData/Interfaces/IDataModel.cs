using RevolutionData.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.Interfaces
{
	public interface IDataModel
	{
		IEnumerable<TShirt> GetAll();

		TShirt Get(int id);
	}
}
