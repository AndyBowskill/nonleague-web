using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using nonleague.web.Entities;
using nonleague.web.Services;

namespace nonleague.web.Controllers
{
    public class MatchController : Controller
    {
        private readonly IMatchService _matchService;
        private readonly ILeagueService _leagueService;
        
        public MatchController(IMatchService matchService, ILeagueService leagueService)
        {
            _matchService = matchService;
            _leagueService = leagueService;
        }
        
        [Route("Match/Competition/{compID:int}/Season/{monthID:int}")]
        public async Task<IActionResult> Index(int compID, int monthID)
        {
            //To do - create/use a view model
            // To do - excepetion error while view Champions League
            //ViewData["Heading"] = _leagueService.GetDescription(compID);

            MatchesCompetitionRoot root = await _matchService.GetFixturesForMonth(compID, monthID);
            var model = root.MatchesCompetition;

            return View(model);
        }
        
    }
}