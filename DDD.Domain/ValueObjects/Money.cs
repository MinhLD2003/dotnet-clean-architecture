using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects
{
    public class Money : ValueObject
    {
        public decimal Amount { get; private set; }
        public string Currency { get; private set; }

        public Money(decimal amount, string currency = "USD")
        {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be negative", nameof(amount));

            if (string.IsNullOrWhiteSpace(currency))
                throw new ArgumentException("Currency cannot be null or empty", nameof(currency));

            Amount = Math.Round(amount, 2);
            Currency = currency.ToUpperInvariant();
        }
        public Money Add(Money other)
        {
            if (Currency != other.Currency)
                throw new InvalidOperationException("Cannot add money with different currencies");

            return new Money(Amount + other.Amount, Currency);
        }

        public Money Subtract(Money other)
        {
            if (Currency != other.Currency)
                throw new InvalidOperationException("Cannot subtract money with different currencies");

            return new Money(Amount - other.Amount, Currency);
        }

        public Money Multiply(decimal factor)
        {
            return new Money(Amount * factor, Currency);
        }

        public static Money Zero(string currency = "USD") => new Money(0, currency);

        public static Money operator +(Money left, Money right) => left.Add(right);
        public static Money operator -(Money left, Money right) => left.Subtract(right);
        public static Money operator *(Money money, decimal factor) => money.Multiply(factor);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Amount;
            yield return Currency;
        }
        public override string ToString() => $"{Amount:C} {Currency}";
    }
}
