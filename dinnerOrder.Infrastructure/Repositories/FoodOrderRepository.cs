using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dinnerOrder.Infrastructure.Entities;

namespace dinnerOrder.Infrastructure.Repositories
{
    public class FoodOrderRepository : IFoodOrderRepository
    {
        ApplicationDbContext _context = new ApplicationDbContext();

        public async Task<bool> AddAsync(FoodOrder foodOrder)
        {
            _context.FoodOrders.Add(foodOrder);
            int response = _context.SaveChanges();
            return response >= 1 ? true : false;
        }
    }
}
