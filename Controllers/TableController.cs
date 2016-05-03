using Microsoft.AspNet.Mvc;

namespace nonleague.web.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Tables";
            
            return View();
        }
        
        public IActionResult Error()
        {
            return View();
        }
    }
}