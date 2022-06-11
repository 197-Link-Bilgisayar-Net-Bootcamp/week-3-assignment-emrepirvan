using LinkBilgisayarWeek3Task.Data.Entities;
using LinkBilgisayarWeek3Task.Data.Repositories;
using LinkBilgisayarWeek3Task.Data.UnitOfWork;
using LinkBilgisayarWeek3Task.Service.Dtos;
using LinkBilgisayarWeek3Task.Service.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkBilgisayarWeek3Task.Service.Services
{
    public class ProductService
    {
        private readonly Repository<Product> _productRepository;
        private readonly Repository<Category> _categoryRepository;
        private readonly Repository<ProductFeature> _productFeatureRepository;
        private readonly LinkDbContext _context;

        private readonly UnitOfWork unitOfWork;
        public ProductService(Repository<Product> productRepository, Repository<Category> categoryRepository, Repository<ProductFeature> productFeatureRepository, UnitOfWork unitOfWork, LinkDbContext context = null)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _productFeatureRepository = productFeatureRepository;
            this.unitOfWork = unitOfWork;
            _context = context;
        }
        public async Task<Response<List<ProductDto>>> GetAll()
        {
            var products = await _context.Products.ToListAsync();


            var productDtos = products.Select(p => new ProductDto()
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                CategoryId = p.CategoryId
            }).ToList();

            if (!productDtos.Any())
            {
                return new Response<List<ProductDto>>()
                {
                    Data = null,
                    Errors = new List<string> { "Urun mevcut Degildir." },
                    Status = 404
                };
            }

            return new Response<List<ProductDto>>()
            {
                Data = productDtos,
                Errors = null,
                Status = 200
            };
        }
    }
}
