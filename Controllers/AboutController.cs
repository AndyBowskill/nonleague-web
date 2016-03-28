using Microsoft.AspNet.Mvc;

namespace nonleague.web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "About Non League";
            
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Application description page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
