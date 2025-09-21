using Microsoft.AspNetCore.Mvc;

namespace ShirtShop.Web.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
