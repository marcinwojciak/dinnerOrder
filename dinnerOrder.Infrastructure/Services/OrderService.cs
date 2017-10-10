using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dinnerOrder.Infrastructure.ViewModels;
using dinnerOrder.Infrastructure.Entities;
using dinnerOrder.Infrastructure.Repositories;
using AutoMapper;

namespace dinnerOrder.Infrastructure.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<bool> AddAsync(OrderViewModel model)
        {
            var order = new Order
            {
                DateOfOrder = DateTime.Now,
                RestaurantId = model.RestaurantId,
            };

            order.ApplicationUserId = _orderRepository.GetUserIdFromUser(model.Username);

            return await _orderRepository.AddAsync(order);
        }

        public bool CheckIfUserCanVote(string username)
        {
            IQueryable<Order> ordersFromToday = _orderRepository.GetAllOrdersFromToday();
            bool response = !ordersFromToday
                .Any(x => x.ApplicationUser.UserName == username);

            return response;
        }

        public async Task<bool> RemoveUsersOrderFromTodayAsync(string username)
        {
            IQueryable<Order> ordersFromToday = _orderRepository.GetAllOrdersFromToday();
            Order orderToRemove = ordersFromToday
                .Where(x => x.ApplicationUser.UserName == username).FirstOrDefault();
            if(orderToRemove != null)
            {
                return await _orderRepository.RemoveAsync(orderToRemove);
            }
            return false;
        }
    }
}

