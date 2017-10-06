using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinnerOrder.Infrastructure.Entities;

namespace dinnerOrder.Infrastructure.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly ApplicationDbContext _context;

        public RestaurantRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Restaurant>> FindBy(Func<Restaurant, bool> predicate)
            => await Task.FromResult(_context.Restaurants.Where(predicate));

        public async Task<Restaurant> GetSingleAsync(string name)
            => await Task.FromResult(_context.Restaurants.SingleOrDefault(x => x.Name == name));
    }
}
