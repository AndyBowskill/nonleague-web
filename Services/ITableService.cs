using System.Threading.Tasks;
using nonleague.web.Entities;

namespace nonleague.web.Services
{
    public interface ITableService
    {
        Task<LeagueTableRoot> GetTable(int competitionID);

    }
    
}