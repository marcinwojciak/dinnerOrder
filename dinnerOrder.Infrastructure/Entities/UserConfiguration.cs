using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinnerOrder.Infrastructure.Entities
{
    public class UserConfiguration : EntityTypeConfiguration<ApplicationUser>
    {
        public UserConfiguration()
        {
            ToTable("dbo.AspNetUsers");

            HasMany(x => x.Orders)
                .WithRequired(x => x.ApplicationUser)
                .HasForeignKey(x => x.ApplicationUserId);

            HasMany(x => x.FoodOrders)
                .WithRequired(x => x.ApplicationUser)
                .HasForeignKey(x => x.ApplicationUserId);
        }
    }
}
