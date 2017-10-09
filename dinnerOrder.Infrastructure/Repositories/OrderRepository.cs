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

        public IQueryable<Order> GetAllOrdersFromToday()
        {
            return _context.Orders
                .Include("Restaurant")  //Include załaduje mi objekt restaurant mając pole RestaurantId.
                .Where(x =>
                    x.DateOfOrder.Value.Year == DateTime.Today.Year &&
                    x.DateOfOrder.Value.Month == DateTime.Today.Month &&
                    x.DateOfOrder.Value.Day == DateTime.Today.Day);
        }

        public async Task<Order> GetSingleAsync(Guid id)
            => await Task.FromResult(_context.Orders.SingleOrDefault(x => x.OrderId == id));

        public string GetUserIdFromUser(string name)
        {
            return _context.Users.Where(x => x.UserName == name)
                          .Select(x => x.Id)
                          .FirstOrDefault();
        }
    }
}
