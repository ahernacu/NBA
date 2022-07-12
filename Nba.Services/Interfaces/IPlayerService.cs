using Nba.models;

namespace Nba.Services.Interfaces
{
    internal interface IPlayerService
    {
        public Player GetPlayer(int id);
        public IEnumerable<Player> GetPlayersTallerThan215();
        public IEnumerable<Player> GetPlayersTallerThan(int height);
    }
}
