using System.Threading.Tasks;

namespace nonleague.web.Services
{
    public interface ITableService
    {
        Task<string> GetTable(int competitionID);

    }
    
}