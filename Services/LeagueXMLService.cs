using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using nonleague.web.Entities;

namespace nonleague.web.Services
{
    public class LeagueXMLService : ILeagueService
    {
        public IEnumerable<League> GetAll()
        {
            var leagues = from element in XDocument.Load("AppData/leagues.xml").Descendants("league") select element;
            
            List<League> leagueList = new List<League>();
            
            foreach (var item in leagues)
            {
                leagueList.Add(new League() {
                    Name = item.Attribute("name").Value,
                    Division = item.Attribute("division").Value,
                    Sponsor = item.Attribute("sponsor").Value,
                    Step = Convert.ToInt32(item.Attribute("step").Value),
                    CompetitionID = Convert.ToInt32(item.Attribute("competitionID").Value)
                });
            }
            
            return leagueList; 
            
        }
    }
    
}