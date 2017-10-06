//using System.Data.Entity.ModelConfiguration;

//namespace dinnerOrder.Infrastructure.Entities
//{
//    public class RestaurantsConfiguration : EntityTypeConfiguration<Restaurant>
//    {
//        public RestaurantsConfiguration()
//        {
//            HasKey(x => x.RestaurantId);

//            Property(x => x.Name).
//              IsRequired().
//              HasMaxLength(30);

//            HasMany(d => d.Orders).
//              WithRequired(c => c.Restaurant).
//              HasForeignKey(c => c.RestaurantId).
//              WillCascadeOnDelete();
//        }
//    }
//}
