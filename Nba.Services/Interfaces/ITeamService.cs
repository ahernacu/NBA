using Nba.Models;

namespace Nba.Services.Interfaces
{
    public interface ITeamService
    {
        Task<Team?> GetTeamAsync(int id);
    }
}
