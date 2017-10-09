using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinnerOrder.Infrastructure.Entities;
using System.Data.Entity;

namespace dinnerOrder.Infrastructure.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public async Task<bool> AddAsync(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            int response = _context.SaveChanges();
            return response >= 1 ? true : false;
        }

        public async Task<IEnumerable<Restaurant>> FindBy(Func<Restaurant, bool> predicate)
            => await Task.FromResult(_context.Restaurants.Where(predicate));

        public async Task<IEnumerable<Restaurant>> GetAllAsync()
            => await _context.Restaurants.ToListAsync();

        public async Task<Restaurant> GetSingleAsync(string name)
            => await Task.FromResult(_context.Restaurants.SingleOrDefault(x => x.Name == name));
    }
}
