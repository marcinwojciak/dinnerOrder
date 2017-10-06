﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace dinnerOrder.Infrastructure.Entities
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }

        public ApplicationDbContext()
           : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Configurations.Add(new UsersConfiguration());
        //    modelBuilder.Configurations.Add(new OrdersConfiguration());
        //    modelBuilder.Configurations.Add(new RestaurantsConfiguration());
        //}
    }
}
