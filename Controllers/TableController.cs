using Microsoft.AspNet.Mvc;
using nonleague.web.Services;

namespace nonleague.web.Controllers
{
    [Route("Table/Competition/{compID:int}/Season/{monthID:int}")]
    public class TableController : Controller
    {
        private readonly ILeagueService _leagueService;
        
        public TableController(ILeagueService leagueService)
        {
            _leagueService = leagueService;
        }
        
        [Route("")]
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