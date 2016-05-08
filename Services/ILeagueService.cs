using System.Collections.Generic;
using nonleague.web.Entities;

namespace nonleague.web.Services
{
    public interface ILeagueService
    {
        IEnumerable<League> GetAll();
        string GetDescription(int competitionID);
    }
    
}