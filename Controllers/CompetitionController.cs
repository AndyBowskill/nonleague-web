using Microsoft.AspNetCore.Mvc;
using nonleague.web.Services;

namespace nonleague.web.Controllers
{
    
    public class CompetitionController : Controller
    {
        private readonly ILeagueService _leagueService;
        
        public CompetitionController(ILeagueService leagueService)
        {
            _leagueService = leagueService;
        }
        
        [Route("Match/[controller]")]
        [Route("/")]
        public IActionResult Match()
        {
            var model = _leagueService.GetAll(); 

            return View(model);
        }
        
        [Route("Table/[controller]")]
        public IActionResult Table()
        {
            var model = _leagueService.GetAll(); 

            return View(model);
        }
        
    }
}
