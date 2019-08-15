using Microsoft.AspNetCore.Mvc;

namespace AspNetBoilerPlate_Demo2.Web.Controllers
{
    public class HomeController : AspNetBoilerPlate_Demo2ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}