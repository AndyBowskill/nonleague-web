using Microsoft.AspNet.Mvc;
using nonleague.web.Services;

namespace nonleague.web.Controllers
{
    public class SeasonController : Controller
    {
        private readonly ISeasonService _seasonService;
        
        public SeasonController(ISeasonService seasonService)
        {
         _seasonService = seasonService;
        }
        
        public IActionResult Index()
        {
            var model = _seasonService.GetSeason(); 
            
            return View(model);
        }
        
        public IActionResult Error()
        {
            return View();
        }
    }
}
