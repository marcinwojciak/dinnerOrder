using System;
using System.ComponentModel.DataAnnotations;

namespace dinnerOrder.Infrastructure.ViewModels
{
    public class RestaurantViewModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "Restaurant's name is too long.")]
        public string Name { get; set; }

        public Guid RestaurantId { get; set; }
    }
}