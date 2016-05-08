using Microsoft.AspNet.Mvc;
using nonleague.web.Services;

namespace nonleague.web.Controllers
{
    public class TableController : Controller
    {
        private readonly ILeagueService _leagueService;
        
        public TableController(ILeagueService leagueService)
        {
            _leagueService = leagueService;
        }
        
        [Route("Table/Competition/{compID:int}/[controller]")]
        public IActionResult Index(int compID)
        {
            //To do - create/use a view model
            ViewData["Heading"] = _leagueService.GetDescription(compID);

            return View();
        }
        
    }
}