using Microsoft.AspNetCore.Mvc;
using nonleague.web.Services;

namespace nonleague.web.Controllers
{
    public class SeasonController : Controller
    {
        private readonly ISeasonService _seasonService;
        private readonly ILeagueService _leagueService;
        
        public SeasonController(ISeasonService seasonService, ILeagueService leagueService)
        {
            _seasonService = seasonService;
            _leagueService = leagueService;
        }
        
        [Route("Fixture/Competition/{compID:int}/[controller]")]
        public IActionResult Index(int compID)
        {
            //To do - create/use a view model
            var model = _seasonService.GetSeason();
            ViewData["Heading"] = _leagueService.GetDescription(compID);

            return View(model);
        }

    }
}
