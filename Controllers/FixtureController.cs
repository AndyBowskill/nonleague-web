using Microsoft.AspNet.Mvc;
using nonleague.web.Services;

namespace nonleague.web.Controllers
{
    [Route("Fixture/[action]")]
    public class FixtureController : Controller
    {
        private readonly ILeagueService _leagueService;
        
        public FixtureController(ILeagueService leagueService)
        {
            _leagueService = leagueService;
        }
        
        [Route("")]
        [Route("/")]
        public IActionResult Index()
        {
            var model = _leagueService.GetAll(); 
            
            return View(model);
        }
        
        [Route("[action]")]
        public IActionResult Error()
        {
            return View();
        }
        
    }
}
