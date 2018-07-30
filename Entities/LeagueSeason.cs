using System.Collections.Generic;

namespace nonleague.web.Entities
{
    public class LeagueSeason
    {
        public int CompetitionID { get; set; }
        public string Description { get; set; }
        public IEnumerable<Month> Season { get; set; }

    }
}