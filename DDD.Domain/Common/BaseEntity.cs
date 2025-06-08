using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Common
{
    public abstract class BaseEntity
    {
        public DateTime CreatedAt { get; protected set; }
        public DateTime? UpdatedAt { get; protected set; }

        protected BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
        }
        protected void SetUpdatedAt()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
