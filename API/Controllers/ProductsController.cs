using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Entity;
using Infrastructure.Data;
using Core.Interface;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repo;

        public ProductsController(IProductRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _repo.GetProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(Guid id)
        {
            return await _repo.GetProductByIdAsync(id);
        }

        [HttpGet("brand")]
        public async Task<ActionResult<List<ProductBrand>>> GetProductBrands()
        {
            var products = await _repo.GetProductBrandsAsync();
            return Ok(products);
        }
        [HttpGet("type")]
        public async Task<ActionResult<List<ProductType>>> GetProductTypes()
        {
            var products = await _repo.GetProductTypesAsync();
            return Ok(products);
        }
    }
}
