using Microsoft.AspNetCore.Mvc;

namespace RootToRise.Controllers
{
    public class WholesaleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
