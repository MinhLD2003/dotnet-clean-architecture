using DDD.Domain.Entities;
using DDD.Domain.Enums;
using DDD.Domain.Repositories;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.Data.Repositories
{
    class OrderRepository : IOrderRepository
    {
        public Task<Order> AddAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(OrderId id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(OrderId id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetByCustomerEmailAsync(string customerEmail)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetByIdAsync(OrderId id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetByStatusAsync(OrderStatus status)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
