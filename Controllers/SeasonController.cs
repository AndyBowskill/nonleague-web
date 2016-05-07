using Microsoft.AspNet.Mvc;
using nonleague.web.Services;

namespace nonleague.web.Controllers
{
    [Route("Fixture/Competition/{compID:int}/[controller]")]
    public class SeasonController : Controller
    {
        private readonly ISeasonService _seasonService;
        
        public SeasonController(ISeasonService seasonService)
        {
            _seasonService = seasonService;   
        }
        
        [Route("")]
        public IActionResult Index()
        {
            var model = _seasonService.GetSeason(); 

            return View(model);
        }
        
        [Route("[action]")]
        public IActionResult Error()
        {
            return View();
        }
        
        [Route("[action]")]
        public string ID(int compID)
        {
            return "ID: " + compID;
        }
    }
}
