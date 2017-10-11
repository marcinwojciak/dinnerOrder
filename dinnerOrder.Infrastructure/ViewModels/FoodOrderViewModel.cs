using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinnerOrder.Infrastructure.ViewModels
{
    public class FoodOrderViewModel
    {
        public Guid RestaurantId { get; set; }
        public string FoodOrderName { get; set; }
        public string Username { get; set; }
    }
}
