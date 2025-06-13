using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities
{
    public class OrderItem
    {
        public ProductId ProductId { get; private set; }
        public string ProductName { get; private set; }
        public Money UnitPrice { get; private set; }
        public int Quantity { get; private set; }
        public Money TotalPrice => UnitPrice * Quantity;
        protected OrderItem() { }
        public OrderItem(ProductId productId, string productName, Money unitPrice, int quantity)
        {
            ProductId = productId ?? throw new ArgumentNullException(nameof(productId));
            ProductName = productName ?? throw new ArgumentNullException(nameof(productName));
            UnitPrice = unitPrice ?? throw new ArgumentNullException(nameof(unitPrice));
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be positive", nameof(quantity));
            Quantity = quantity;
        }
        internal void UpdateQuantity(int newQuantity)
        {
            if (newQuantity <= 0)
                throw new ArgumentException("Quantity must be positive", nameof(newQuantity));
            Quantity = newQuantity;
        }
    }
}
