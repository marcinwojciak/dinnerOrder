using dinnerOrder.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinnerOrder.Infrastructure.Repositories
{
    public interface IFoodOrderRepository
    {
        Task<bool> AddAsync(FoodOrder foodOrder);
    }
}
