using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dinnerOrder.Infrastructure.ViewModels;
using dinnerOrder.Infrastructure.Entities;
using dinnerOrder.Infrastructure.Repositories;

namespace dinnerOrder.Infrastructure.Services
{
    public class FoodOrderService : IFoodOrderService
    {
        private readonly IFoodOrderRepository _foodOrderRepository;
        private readonly IOrderRepository _orderRepository;

        public FoodOrderService(IFoodOrderRepository foodOrderRepository, IOrderRepository orderRepository)
        {
            _foodOrderRepository = foodOrderRepository;
            _orderRepository = orderRepository;
        }

        public async Task<bool> AddAsync(FoodOrderViewModel model)
        {
            var foodOrder = new FoodOrder
            {
                Id = Guid.NewGuid(),
                FoodName = model.FoodOrderName,
                RestaurantId = model.RestaurantId,
            };

            foodOrder.ApplicationUserId = _orderRepository.GetUserIdFromUser(model.Username);

            return await _foodOrderRepository.AddAsync(foodOrder);
        }
    }
}
