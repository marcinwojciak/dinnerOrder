using dinnerOrder.Infrastructure.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using dinnerOrder.Infrastructure.ViewModels;

namespace dinnerOrder.Infrastructure.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetSingleAsync(Guid id);
        Task<Order> GetOrderByUserAsync(string userId);
        Task<bool> AddAsync(Order order);
        Task<bool> RemoveAsync(Order order);
        string GetUserIdFromUser(string name);
        IQueryable<Order> GetAllOrdersFromToday();
        RestaurantWithMostVotes GetRestaurantWithMostVotes();
    }
}
