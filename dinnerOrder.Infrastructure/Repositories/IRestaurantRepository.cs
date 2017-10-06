using dinnerOrder.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dinnerOrder.Infrastructure.Repositories
{
    public interface IRestaurantRepository
    {
        Task<Restaurant> GetSingleAsync(string name);
        Task AddAsync(Restaurant restaurant);
        Task<IEnumerable<Restaurant>> FindBy(Func<Restaurant, bool> predicate);
    }
}
