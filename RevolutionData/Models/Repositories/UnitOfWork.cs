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
	public class UnitOfWork : IUnitOfWork
	{
		private bool _disposed = false;
		private readonly RevolutionShopDbContext _context;
		private TShirtRepository? _tShirtRepository;
		private ShopperRepository? _shopperRepository;

		public UnitOfWork(RevolutionShopDbContext context)
		{
			_context = context;
		}

		public IDataModel<TShirt> TShirts
		{
			get
			{
				if (_tShirtRepository == null)
				{
					_tShirtRepository = new TShirtRepository(_context);
				}

				return _tShirtRepository;
			}
		}

		public IDataModel<Shopper> Shoppers
		{
			get
			{
				if (_shopperRepository == null)
				{
					_shopperRepository = new ShopperRepository(_context);
				}

				return _shopperRepository;
			}
		}

		public void Save()
		{
			_context.SaveChanges();
		}

		public virtual void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				if (disposing)
				{
					_context.Dispose();
				}

				_disposed = true;
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
