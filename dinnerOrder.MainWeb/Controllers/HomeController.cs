using dinnerOrder.Infrastructure.Services;
using dinnerOrder.Infrastructure.ViewModels;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace dinnerOrder.MainWeb.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantService _restaurantService;

        public HomeController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
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

        public JsonResult GetAllRestaurants()
        {
            var result = _restaurantService.GetAllAsync();

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Authorize]
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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}