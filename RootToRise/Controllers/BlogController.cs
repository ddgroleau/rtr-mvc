using Microsoft.AspNetCore.Mvc;

namespace RootToRise.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
