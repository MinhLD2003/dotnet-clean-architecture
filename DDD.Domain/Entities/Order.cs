using DDD.Domain.Common;
using DDD.Domain.Enums;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities
{
    public class Order : BaseEntity
    {
        private readonly List<OrderItem> _orderItems;

        public OrderId Id { get; private set; }
        public string CustomerEmail { get; private set; }
        public OrderStatus Status { get; private set; }
        public Money TotalAmount { get; private set; }
        public IReadOnlyList<OrderItem> OrderItems => _orderItems.AsReadOnly();
    }
}
