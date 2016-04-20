using System.Collections.Generic;
using nonleague.web.Entities;

namespace nonleague.web.Services
{
    public interface ISeasonService
    {
        IEnumerable<Month> GetSeason();
    }
    
}