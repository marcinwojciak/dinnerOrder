using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace dinnerOrder.Infrastructure.Entities
{
    public class FoodOrder
    {
        public Guid Id { get; set; }
        public string FoodName { get; set; }
        public Guid RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
