using dinnerOrder.Infrastructure.Entities;
using dinnerOrder.Infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinnerOrder.Infrastructure.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetSingleAsync(Guid id);
        Task<bool> AddAsync(Order order);
        string GetUserIdFromUser(string name);
        IQueryable<Order> GetAllOrdersFromToday();
    }
}
