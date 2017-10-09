using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinnerOrder.Infrastructure.ViewModels
{
    public class OrderViewModel
    {
        public Guid RestaurantId { get; set; }

        public string Username { get; set; }
    }
}
