using DDD.Domain.Entities;
using DDD.Domain.Enums;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetByIdAsync(OrderId id);
        Task<IEnumerable<Order>> GetAllAsync();
        Task<IEnumerable<Order>> GetByCustomerEmailAsync(string customerEmail);
        Task<IEnumerable<Order>> GetByStatusAsync(OrderStatus status);
        Task<Order> AddAsync(Order order);
        Task UpdateAsync(Order order);
        Task DeleteAsync(OrderId id);
        Task<bool> ExistsAsync(OrderId id);
    }
}
