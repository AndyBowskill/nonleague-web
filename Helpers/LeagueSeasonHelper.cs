using System.Collections.Generic;
using nonleague.web.Entities;

namespace nonleague.web.Helper
{
    public class LeagueSeasonHelper
    {
        public int CompetitionID { get; set; }
        public string Description { get; set; }
        public IEnumerable<Month> Season { get; set; }

    }
}