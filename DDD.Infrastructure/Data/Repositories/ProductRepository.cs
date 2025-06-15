using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.Data.Repositories
{
    class ProductRepository : IProductRepository
    {
        public Task<Product> AddAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ProductId id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetActiveProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(ProductId id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> SearchByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
