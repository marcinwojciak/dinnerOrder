using dinnerOrder.Infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinnerOrder.Infrastructure.Services
{
    public interface IOrderService
    {
        Task<bool> AddAsync(OrderViewModel model);
        bool CheckIfUserCanVote(string name);
    }
}
