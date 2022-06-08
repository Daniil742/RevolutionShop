using RevolutionData.Interfaces;
using RevolutionData.Models.DB;
using RevolutionData.Models.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.Models
{
	public class DataModel : IDataModel
	{
		private readonly RevolutionShopDbContext _context;

		public DataModel(RevolutionShopDbContext context)
		{
			_context = context;
		}

		public IEnumerable<TShirt> GetAll()
		{
			return _context.TShirts.ToList();
		}

		public TShirt Get(int id)
		{
			return _context.TShirts.FirstOrDefault(x => x.Id == id);
		}
	}
}
