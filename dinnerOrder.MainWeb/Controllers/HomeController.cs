using dinnerOrder.Infrastructure.Repositories;
using System;
using System.Web.Mvc;

namespace dinnerOrder.MainWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetTestRestaurants(string name)
        {
            return Json(name + DateTime.Now, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddRestaurant(string name)
        {
            return Json(name + DateTime.Now, JsonRequestBehavior.AllowGet);
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