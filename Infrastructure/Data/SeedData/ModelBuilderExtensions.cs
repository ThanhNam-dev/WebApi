using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.SeedData
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Any guid
            Guid typeId = new Guid();
            typeId = Guid.NewGuid();
            Guid grandId = new Guid();
            grandId = Guid.NewGuid();
            modelBuilder.Entity<ProductType>().HasData(new ProductType
            {
                Id = typeId,
                Name = "Type 1"
            },new ProductType {
                Id = Guid.NewGuid(),
                Name = "Type 2"
            }, new ProductType
            {
                Id = Guid.NewGuid(),
                Name = "Type 3"
            }, new ProductType
            {
                Id = Guid.NewGuid(),
                Name = "Type 4"
            });
            modelBuilder.Entity<ProductBrand>().HasData(new ProductBrand
            {
                Id = grandId,
                Name = "Grand 1"
            }, new ProductBrand
            {
                Id = Guid.NewGuid(),
                Name = "Grand 2"
            }, new ProductBrand
            {
                Id = Guid.NewGuid(),
                Name = "Grand 3"
            }, new ProductBrand
            {
                Id = Guid.NewGuid(),
                Name = "Grand 4"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name= "Product 1",
                Description= "Product 1",
                Price= 200,
                PictureUrl= "images/products/p1.png",
                ProductTypeId= typeId,
                ProductBrandId= grandId
            });

        }
    }
}
