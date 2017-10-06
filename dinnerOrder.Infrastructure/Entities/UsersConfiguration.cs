using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinnerOrder.Infrastructure.Entities
{
    public class UsersConfiguration : EntityTypeConfiguration<ApplicationUser>
    {
        //public UsersConfiguration()
        //{
        //    HasMany(d => d.Orders).
        //        WithRequired(c => c.ApplicationUser).
        //        HasForeignKey(c => c.OrderId).
        //        WillCascadeOnDelete();
        //}
    }
}
