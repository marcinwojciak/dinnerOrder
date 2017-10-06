using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dinnerOrder.Infrastructure.Entities;
using dinnerOrder.Infrastructure.Repositories;

namespace dinnerOrder.Infrastructure.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _bookRepository;
        //private readonly IMapper _mapper;

        public RestaurantService(IRestaurantRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public Task AddAsync(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Restaurant>> FindBy(Func<Restaurant, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<RestaurantViewModel> GetSingleAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
