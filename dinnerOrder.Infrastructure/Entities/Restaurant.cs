﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dinnerOrder.Infrastructure.Entities
{
    public class Restaurant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid RestaurantId { get; set; }
        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<FoodOrder> FoodOrders { get; set; }
    }
}
