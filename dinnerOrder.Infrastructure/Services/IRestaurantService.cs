using dinnerOrder.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dinnerOrder.Infrastructure.ViewModels;

namespace dinnerOrder.Infrastructure.Services
{
    public interface IRestaurantService
    {
        IEnumerable<RestaurantViewModel> GetAllAsync();
        Task<RestaurantViewModel> GetSingleAsync(string name);
        Task<bool> AddAsync(RestaurantViewModel model);
    }
}
