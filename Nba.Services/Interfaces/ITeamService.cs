using Nba.Models;

namespace Nba.Services.Interfaces
{
    internal interface ITeamService
    {
        Task<Team?> GetTeamAsync(int id);
    }
}
