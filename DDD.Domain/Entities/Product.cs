using DDD.Domain.Common;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities
{
    public class Product : BaseEntity
    {
        public ProductId Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Money Price { get; private set; }
        public int StockQuantity { get; private set; }
        public bool IsActive { get; private set; }

        protected Product() { }
        public Product(ProductId id, string name, string description, Money price, int stockQuantity)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            SetName(name);
            SetDescription(description);
            SetPrice(price);
            SetStockQuantity(stockQuantity);
            IsActive = true;
        }
        public void UpdateDetails(string name, string description, Money price)
        {
            SetName(name);
            SetDescription(description);
            SetPrice(price);
            SetUpdatedAt();
        }

        public void UpdateStock(int quantity)
        {
            SetStockQuantity(quantity);
            SetUpdatedAt();
        }
        public void ReduceStock(int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be positive", nameof(quantity));

            if (StockQuantity < quantity)
                throw new InvalidOperationException("Insufficient stock");

            StockQuantity -= quantity;
            SetUpdatedAt();
        }
        public void Activate()
        {
            IsActive = true;
            SetUpdatedAt();
        }
        public void Deactivate()
        {
            IsActive = false;
            SetUpdatedAt();
        }

        public bool IsAvailable(int requestedQuantity = 1)
        {
            return IsActive && StockQuantity >= requestedQuantity;
        }

        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Product name is required", nameof(name));

            if (name.Length > 200)
                throw new ArgumentException("Product name cannot exceed 200 characters", nameof(name));

            Name = name.Trim();
        }

        private void SetDescription(string description)
        {
            Description = description?.Trim();
        }

        private void SetPrice(Money price)
        {
            Price = price ?? throw new ArgumentNullException(nameof(price));
        }
        private void SetStockQuantity(int quantity)
        {
            if (quantity < 0)
                throw new ArgumentException("Stock quantity cannot be negative", nameof(quantity));

            StockQuantity = quantity;
        }
    }
}
