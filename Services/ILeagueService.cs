using System.Collections.Generic;
using nonleague.web.Models;

namespace nonleague.web.Services
{
    public interface ILeagueService
    {
        IEnumerable<League> GetAll();
    }
    
}