using Nba.Models;

namespace Nba.Services.Interfaces
{
    internal interface ITeamService
    {
        public Team GetTeam(int id);
    }
}
