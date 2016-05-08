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
        
        [Route("Fixture/Competition/{compID:int}/Season/{monthID:int}")]
        public IActionResult Index()
        {
            //To do - create/use a view model
            var model = _leagueService.GetAll(); 

            return View(model);
        }
        
    }
}