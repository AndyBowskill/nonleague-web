using System.Threading.Tasks;
using nonleague.web.Entities;

namespace nonleague.web.Services
{
    public interface IMatchService
    {
        Task<MatchesCompetitionRoot> GetFixturesForMonth(int competitionID, int monthID);

    }
    
}