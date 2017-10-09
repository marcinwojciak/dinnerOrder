using dinnerOrder.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinnerOrder.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        ApplicationDbContext _context = new ApplicationDbContext();

        public async Task<bool> AddAsync(Order order)
        {
            _context.Orders.Add(order);
            int response = _context.SaveChanges();
            return response >= 1 ? true : false;
        }

        public string GetUserIdFromUser(string name)
        {
            return _context.Users.Where(x => x.UserName == name)
                          .Select(x => x.Id)
                          .FirstOrDefault();
        }
    }
}
