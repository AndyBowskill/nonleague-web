using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using nonleague.web.Entities;
using nonleague.web.Helper;
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
            //ToDo - Return matches node from service
            var matchesCompetitionRoot = await _matchService.GetFixturesForMonth(compID, monthID);

            var matchesCompetitionHelper = new MatchesCompetitionHelper();
            matchesCompetitionHelper.Description = _leagueService.GetDescription(compID);
            matchesCompetitionHelper.MatchesCompetition = matchesCompetitionRoot.MatchesCompetition;

            return View(matchesCompetitionHelper);
        }
        
    }
}