using System;

namespace dinnerOrder.Infrastructure.ViewModels
{
    public class RestaurantWithMostVotes
    {
        public Guid RestaurantId { get; set; }
        public string Name { get; set; }
        public int NumberOfVotes { get; set; }
    }
}