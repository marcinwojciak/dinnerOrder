using System;
using System.Threading.Tasks;
using dinnerOrder.Infrastructure.Entities;
using dinnerOrder.Infrastructure.Repositories;
using dinnerOrder.Infrastructure.ViewModels;
using AutoMapper;
using System.Collections.Generic;

namespace dinnerOrder.Infrastructure.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;

        public RestaurantService(IRestaurantRepository bookRepository, IMapper mapper)
        {
            _restaurantRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddAsync(RestaurantViewModel model)
        {
            var restaurant = new Restaurant { RestaurantId = Guid.NewGuid(), Name = model.Name };
            return await _restaurantRepository.AddAsync(restaurant);
        }

        public async Task<IEnumerable<RestaurantViewModel>> GetAllAsync()
        {
            var restaurants = await _restaurantRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<Restaurant>, IEnumerable<RestaurantViewModel>>(restaurants);
        }

        public async Task<RestaurantViewModel> GetSingleAsync(string name)
        {
            var restaurant = await _restaurantRepository.GetSingleAsync(name);

            return _mapper.Map<Restaurant, RestaurantViewModel>(restaurant);
        }
    }
}
