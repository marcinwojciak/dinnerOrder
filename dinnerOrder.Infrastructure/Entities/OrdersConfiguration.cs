using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinnerOrder.Infrastructure.Entities
{
    public class OrdersConfiguration : EntityTypeConfiguration<Order>
    {
        public OrdersConfiguration()
        {
            HasKey(x => x.OrderId);
        }
    }
}
