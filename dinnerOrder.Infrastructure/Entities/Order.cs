using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinnerOrder.Infrastructure.Entities
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid OrderId { get; set; }
        public DateTime? DateOfOrder { get; set; }
        public Guid RestaurantId { get; set; }

        //public Restaurant Restaurant { get; set; }
        //public Guid ApplicationUserId { get; set; }
        //public ApplicationUser ApplicationUser { get; set; }
    }
}
