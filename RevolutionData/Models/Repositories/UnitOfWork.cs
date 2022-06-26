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
		private ProductRepository? _productRepository;
		private ProductTypeRepository? _productTypeRepository;

		public UnitOfWork(RevolutionShopDbContext context)
		{
			_context = context;
		}

		public IDataModel<Product> Products
		{
			get
			{
				if (_productRepository == null)
				{
					_productRepository = new ProductRepository(_context);
				}

				return _productRepository;
			}
		}

		public IDataModel<ProductType> ProductTypes
		{
			get
			{
				if (_productTypeRepository == null)
				{
					_productTypeRepository = new ProductTypeRepository(_context);
				}

				return _productTypeRepository;
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
