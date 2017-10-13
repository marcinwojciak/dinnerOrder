using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

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
