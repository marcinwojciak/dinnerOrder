﻿using dinnerOrder.Infrastructure.ViewModels;
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
        Task<bool> RemoveUsersOrderFromTodayAsync(string username);
        bool CheckIfUserCanVote(string name);
        RestaurantWithMostVotes GetRestaurantWithMostVotes();
    }
}
