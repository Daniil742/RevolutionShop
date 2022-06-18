using RevolutionData.Interfaces;
using RevolutionData.Models.DB;
using RevolutionData.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionData.Models.Repositories
{
	public class TShirtRepository : IDataModel<TShirt>
	{
		private readonly RevolutionShopDbContext _context;

		public TShirtRepository(RevolutionShopDbContext context)
		{
			_context = context;
		}

		public List<TShirt> GetAll()
		{
			return _context.TShirts.ToList();
		}

		public TShirt Get(int id)
		{
			return _context.TShirts.FirstOrDefault(x => x.Id == id);
		}
	}
}
