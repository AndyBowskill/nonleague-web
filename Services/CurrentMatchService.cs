using System.Threading.Tasks;
using nonleague.web.Entities;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace nonleague.web.Services
{
    public class CurrentMatchService : IMatchService
    {
        public async Task<MatchesCompetitionRoot> GetFixturesForMonth(int competitionID, int monthID)
        {
            string responseJson = "";
            MatchesCompetitionRoot root = null;
            
            using (var client = new HttpClient())
            {
                var URI = string.Format("https://www.footballwebpages.co.uk/fixtures-results.json?comp={0}&month={1}",competitionID, monthID);
                client.BaseAddress = new Uri(URI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync(URI);
        
                if (response.IsSuccessStatusCode)
                {
                    responseJson = await response.Content.ReadAsStringAsync();
                    root = JsonConvert.DeserializeObject<MatchesCompetitionRoot>(responseJson);
                }
                    
            }
            
            return root;

        }

    }
    
}