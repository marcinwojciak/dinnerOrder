using dinnerOrder.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dinnerOrder.Infrastructure.ViewModels;

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

        public async Task<Order> GetOrderByUserAsync(string userId)
            => await Task.FromResult(_context.Orders.SingleOrDefault(x => x.ApplicationUserId == userId));

        public RestaurantWithMostVotes GetRestaurantWithMostVotes()
        {
            var output =_context.Database
                .SqlQuery<RestaurantWithMostVotes>(@"SELECT TOP(1) RestaurantId, Count(OrderId) as NumberOfVotes, (Select Name FROM Restaurants WHERE RestaurantId = o.RestaurantId) as Name
                                                     FROM [DinnerOrder].[dbo].[Orders] as o
                                                     GROUP BY o.RestaurantId
                                                     Order By NumberOfVotes DESC").FirstOrDefault();

            return output;
        }

        public async Task<Order> GetSingleAsync(Guid id)
            => await Task.FromResult(_context.Orders.SingleOrDefault(x => x.OrderId == id));

        public string GetUserIdFromUser(string name)
        {
            return _context.Users.Where(x => x.UserName == name)
                          .Select(x => x.Id)
                          .FirstOrDefault();
        }

        public async Task<bool> RemoveAsync(Order order)
        {
            _context.Orders.Remove(order);
            int response = _context.SaveChanges();
            return response >= 1 ? true : false;
        }
    }
}
