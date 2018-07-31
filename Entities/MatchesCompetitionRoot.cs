using System.Collections.Generic;

namespace nonleague.web.Entities
{
    public class Match
    {
        public string Date { get; set; }
        private string _time;
        public string Time { 
            get => this._time;
            set => this._time = value.Length <= 5 ? value : value.Substring(0, 5);
        }
        public string Status { get; set; }
        public string HomeTeamName { get; set; }
        public int HomeTeamScore { get; set; }
        public string AwayTeamName { get; set; }
        public int AwayTeamScore { get; set ;}
    }

    public class MatchesCompetition
    {
        public string Competition { get; set; }
        public string Description { get; set; }
        public List<Match> Match { get; set; }
    }

    public class MatchesCompetitionRoot
    {
        public MatchesCompetition MatchesCompetition { get; set; }
    }
    
}