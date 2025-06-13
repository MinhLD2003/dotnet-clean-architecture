using DDD.Domain.Entities;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Services
{
    public class PricingService
    {
        public Money CalculateOrderTotal(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));
            if (order.OrderItems == null || !order.OrderItems.Any())
                return new Money(0);
            var total = Money.Zero(order.OrderItems.First().UnitPrice.Currency);
            foreach (var item in order.OrderItems)
            {
                total = total + item.TotalPrice;
            }
            return total;
        }

        public Money ApplyDiscount(Money total, decimal discountPercentage)
        {
            if (total == null)
                throw new ArgumentNullException(nameof(total));
            if (discountPercentage < 0 || discountPercentage > 100)
                throw new ArgumentOutOfRangeException(nameof(discountPercentage), "Discount percentage must be between 0 and 100");
            var discountAmount = total.Amount * (discountPercentage / 100);
            return total - new Money(discountAmount, total.Currency);
        }
    }
}
