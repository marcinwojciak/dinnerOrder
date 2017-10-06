using dinnerOrder.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dinnerOrder.MainWeb.ViewModels;

namespace dinnerOrder.Infrastructure.Services
{
    public interface IRestaurantService
    {
        Task<RestaurantViewModel> GetSingleAsync(string name);
        Task AddAsync(Restaurant restaurant);
        Task<IEnumerable<Restaurant>> FindBy(Func<Restaurant, bool> predicate);
    }
}
