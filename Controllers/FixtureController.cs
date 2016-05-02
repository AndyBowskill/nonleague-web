using Microsoft.AspNet.Mvc;
using nonleague.web.Services;

namespace nonleague.web.Controllers
{
    public class FixtureController : Controller
    {
        private readonly ILeagueService _leagueService;
        private readonly ISeasonService _seasonService;
        
        public FixtureController(ILeagueService leagueService, ISeasonService seasonService)
        {
            _leagueService = leagueService;
            _seasonService = seasonService;   
        }
        
        public IActionResult Index()
        {
            var model = _leagueService.GetAll(); 
            
            return View(model);
        }
        
        public IActionResult Season()
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
