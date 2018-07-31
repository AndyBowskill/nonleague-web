using System.Collections.Generic;

namespace nonleague.web.Entities
{
    public class Team
    {
        public string Position { get; set; }
        public string Name { get; set; }
        public string Played { get; set; }
        public string Won { get; set; }
        public string Drawn { get; set; }
        public string Lost { get; set; }
        public string For { get; set; }
        public string Against { get; set; }
        public string GoalDifference { get; set; }
        public string Points { get; set; }
    }

    public class LeagueTable
    {
        public string Competition { get; set; }
        public string Description { get; set; }
        public List<Team> Team { get; set; }
    }

    public class LeagueTableRoot
    {
        public LeagueTable LeagueTable { get; set; }
    }
    
}