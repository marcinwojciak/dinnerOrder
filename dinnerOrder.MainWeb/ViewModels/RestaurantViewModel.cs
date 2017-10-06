using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dinnerOrder.MainWeb.ViewModels
{
    public class RestaurantViewModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "Restaurant's name is too long.")]
        public string Name { get; set; }
    }
}