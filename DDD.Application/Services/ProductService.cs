using DDD.Application.DTOs;
using DDD.Application.Repositories;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Services
{
    class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }   

        public async Task<ProductDTO> GetProductByIdAsync(Guid id)
        {
            var product = await _productRepository.GetByIdAsync(new ProductId(id));
            if (product == null)
            {
                return null;
            }
            return new ProductDTO
            {
                Id = product.Id.Value,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price.Amount,
                Currency = product.Price.Currency,
                StockQuantity = product.StockQuantity,
                IsActive = product.IsActive,
                CreatedAt = product.CreatedAt,
                UpdatedAt = product.UpdatedAt
            };
        }
    }
}
