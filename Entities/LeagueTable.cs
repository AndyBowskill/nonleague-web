using System.Collections.Generic;

namespace nonleague.web.Entities
{
    public class Team
    {
        public string position { get; set; }
        public string name { get; set; }
        public string played { get; set; }
        public string won { get; set; }
        public string drawn { get; set; }
        public string lost { get; set; }
        public string @for { get; set; }
        public string against { get; set; }
        public string goalDifference { get; set; }
        public string points { get; set; }
    }

    public class LeagueTable
    {
        public string competition { get; set; }
        public string description { get; set; }
        public List<Team> team { get; set; }
    }

    public class LeagueTableRoot
    {
        public LeagueTable leagueTable { get; set; }
    }
    
}