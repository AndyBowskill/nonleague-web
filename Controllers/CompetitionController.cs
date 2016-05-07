using Microsoft.AspNet.Mvc;
using nonleague.web.Services;

namespace nonleague.web.Controllers
{
    [Route("Fixture/[controller]")]
    public class CompetitionController : Controller
    {
        private readonly ILeagueService _leagueService;
        
        public CompetitionController(ILeagueService leagueService)
        {
            _leagueService = leagueService;
        }
        
        [Route("")]
        [Route("/")]
        public IActionResult Fixture()
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
