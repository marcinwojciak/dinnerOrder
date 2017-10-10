using System.Collections.Generic;


namespace dinnerOrder.Infrastructure.ViewModels
{
    public class RestaurantExtendedViewModel
    {
        public IEnumerable<RestaurantViewModel> Restaurants { get; set; }
        public bool CanVote { get; set; }
        public RestaurantWithMostVotes RestaurantWithMostVotes { get;set;}
    }
}