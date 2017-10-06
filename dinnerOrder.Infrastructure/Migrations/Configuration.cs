namespace dinnerOrder.Infrastructure.Migrations
{
    using dinnerOrder.Infrastructure.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            context.Restaurants.AddOrUpdate(
                x => x.RestaurantId,
                new Restaurant { RestaurantId = Guid.NewGuid(), Name = "Restaurant1"},
                new Restaurant { RestaurantId = Guid.NewGuid(), Name = "Restaurant2" },
                new Restaurant { RestaurantId = Guid.NewGuid(), Name = "Restaurant3" }
                );

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
