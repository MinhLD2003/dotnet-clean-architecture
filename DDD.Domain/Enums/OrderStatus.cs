using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Enums
{
    public enum OrderStatus
    {
        Pending = 1,
        Confirmed = 2,
        Processing = 3,
        Shipped = 4,
        Delivered = 5,
        Completed = 6,
        Cancelled = 7,
        Refunded = 8
    }
}
