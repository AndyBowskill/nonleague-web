using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using nonleague.web.Entities;
using nonleague.web.Services;

namespace nonleague.web.Controllers
{
    public class TableController : Controller
    {
        private readonly ILeagueService _leagueService;
        private readonly ITableService _leagueTableService;
        
        public TableController(ILeagueService leagueService, ITableService leagueTableService)
        {
            _leagueService = leagueService;
            _leagueTableService = leagueTableService;
        }
        
        [Route("Table/Competition/{compID:int}/[controller]")]
        public async Task<IActionResult> Index(int compID)
        {
            //To do - create/use a view model
            ViewData["Heading"] = _leagueService.GetDescription(compID);

            //ToDo - Return league table node from service
            LeagueTableRoot root = await _leagueTableService.GetTable(compID);
            var model = root.LeagueTable;

            //ViewData["Test"] = await _leagueTableService.GetTable(compID);

            return View(model);
        }
        
    }
}