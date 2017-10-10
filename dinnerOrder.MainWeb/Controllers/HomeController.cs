using dinnerOrder.Infrastructure.Services;
using dinnerOrder.Infrastructure.ViewModels;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace dinnerOrder.MainWeb.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantService _restaurantService;
        private IOrderService _orderService;

        public HomeController(IRestaurantService restaurantService, IOrderService orderService)
        {
            _restaurantService = restaurantService;
            _orderService = orderService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetTestRestaurants(string name)
        {
            var result = _restaurantService.GetSingleAsync(name);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetRestaurantsViewModel()
        {
            RestaurantExtendedViewModel exModel = new RestaurantExtendedViewModel();
            exModel.Restaurants = _restaurantService.GetAllAsync();
            exModel.CanVote = _orderService.CheckIfUserCanVote(User.Identity.Name);
            exModel.RestaurantWithMostVotes = _orderService.GetRestaurantWithMostVotes();
            return Json(exModel, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddRestaurant(RestaurantViewModel model)
        {
            string output = "Error";

            if (ModelState.IsValid)
            {    
                Task<bool> result = _restaurantService.AddAsync(model);
                if (result.Result)
                {
                    output = "Success";
                }
            }

            return Json(output, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddNewOrder(OrderViewModel model)
        {
            string output = "Error";
            model.Username = User.Identity.Name;

            if (ModelState.IsValid)
            {
                Task<bool> result = _orderService.AddAsync(model);
                if (result.Result)
                {
                    output = "Success";
                }
            }

            return Json(output, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult RemoveLastOrder()
        {
            string output = "Error";

                Task<bool> result = _orderService.RemoveUsersOrderFromTodayAsync(User.Identity.Name);

                if (result.Result)
                {
                    output = "Success";
                }

            return Json(output, JsonRequestBehavior.AllowGet);
        }
    }
}