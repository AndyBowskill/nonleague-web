
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using nonleague.web.Entities;

namespace nonleague.web.Services
{
    public class CurrentSeasonService : ISeasonService
    {
        public IEnumerable<Month> GetSeason()
        {
            var leagues = from element in XDocument.Load("AppData/season.xml").Descendants("season") select element;
            
            List<Month> season = new List<Month>();
            
            foreach (var item in season)
            {
                season.Add(new Month() {
                    Name = item.Attribute("name").Value,
                    ID = Convert.ToInt32(item.Attribute("ID").Value)
                });
            }
            
            return season; 
            
        }
    }
    
}