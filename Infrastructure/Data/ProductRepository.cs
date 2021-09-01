using Core.Entity;
using Core.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
	public class ProductRepository : IProductRepository
	{
		private readonly DataDbContext _context;

		public ProductRepository(DataDbContext context)
		{
			_context = context;
		}

		public async Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync()
		{
			return await _context.ProductBrand.ToListAsync();
		}

		public async Task<Product> GetProductByIdAsync(Guid id)
		{
			return await _context.Product.Include(p => p.ProductType).Include(p => p.ProductBrand).FirstOrDefaultAsync(x => x.Id == id);
		}

		public async Task<IReadOnlyList<Product>> GetProductsAsync()
		{
			return await _context.Product.Include(p => p.ProductType).Include(p => p.ProductBrand).ToListAsync();
		}

		public async Task<IReadOnlyList<ProductType>> GetProductTypesAsync()
		{
			return await _context.ProductType.ToListAsync();
		}
	}
}
