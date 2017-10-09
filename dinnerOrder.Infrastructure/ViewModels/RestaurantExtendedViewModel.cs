using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dinnerOrder.Infrastructure.ViewModels
{
    public class RestaurantExtendedViewModel
    {
        public IEnumerable<RestaurantViewModel> Restaurants { get; set; }
        public bool CanVote { get; set; }
    }
}