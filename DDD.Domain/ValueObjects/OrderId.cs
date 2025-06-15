using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects
{
    public class OrderId : ValueObject
    {
        public Guid Value { get; private set; }

        public OrderId(Guid value)
        {
            if (value == Guid.Empty)
                throw new ArgumentException("OrderId cannot be empty", nameof(value));

            Value = value;
        }

        public static OrderId New() => new OrderId(Guid.NewGuid());

        public static implicit operator Guid(OrderId orderId) => orderId.Value;
        public static implicit operator OrderId(Guid guid) => new OrderId(guid);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();
    }
}
