using Nba.models;

namespace Nba.Services.Interfaces
{
    internal interface IPlayerService
    {
        Task<Player?> GetPlayerAsync(int id);
        IEnumerable<Player> GetPlayersTallerThan215();
        IEnumerable<Player> GetPlayersTallerThan(int height);
    }
}
