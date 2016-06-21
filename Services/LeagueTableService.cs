
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using nonleague.web.Entities;

namespace nonleague.web.Services
{
    public class LeagueTableService : ITableService
    {
        public async Task<LeagueTableRoot> GetTable(int competitionID)
        {
            string responseJson = "";
            LeagueTableRoot root = null;
            
            using (var client = new HttpClient())
            {
                var URI = string.Format("http://www.footballwebpages.co.uk/league.json?comp={0}",competitionID);
                client.BaseAddress = new Uri(URI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync(URI);
        
                if (response.IsSuccessStatusCode)
                {
                    responseJson = await response.Content.ReadAsStringAsync();
                    root = JsonConvert.DeserializeObject<LeagueTableRoot>(responseJson);
                }
                
                //var httpClient = new HttpClient();
                //httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                //var result = await httpClient.GetStringAsync("http://www.footballwebpages.co.uk/league.json?comp=13");
            }
            
            return root;
            
        }
    }
    
}