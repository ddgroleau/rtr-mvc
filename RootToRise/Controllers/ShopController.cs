using Microsoft.AspNetCore.Mvc;

namespace RootToRise.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
