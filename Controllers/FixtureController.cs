using Microsoft.AspNet.Mvc;
using nonleague.web.Services;

namespace nonleague.web.Controllers
{
    public class FixtureController : Controller
    {
        private readonly ILeagueService _leagueService;
        
        public FixtureController(ILeagueService leagueService)
        {
         _leagueService = leagueService;   
        }
        
        public IActionResult Index()
        {
            var model = _leagueService.GetAll(); 
            
            return View(model);
        }
        
        public IActionResult Error()
        {
            return View();
        }
    }
}
