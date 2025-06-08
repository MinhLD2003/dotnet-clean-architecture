using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects
{
    public class ProductId : ValueObject
    {
        public Guid Value { get; private set; }

        public ProductId(Guid value)
        {
            if (value == Guid.Empty)
                throw new ArgumentException("ProductId cannot be empty", nameof(value));

            Value = value;
        }

        public static ProductId New() => new ProductId(Guid.NewGuid());

        public static implicit operator Guid(ProductId productId) => productId.Value;
        public static implicit operator ProductId(Guid guid) => new ProductId(guid);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();
    }
}
