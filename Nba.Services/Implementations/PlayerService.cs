using Nba.models;
using Nba.Services.Interfaces;
using System.Text.Json;

namespace Nba.Services.Implementations
{
    public class PlayerService : IPlayerService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PlayerService(IHttpClientFactory httpClientFactory) =>
            _httpClientFactory = httpClientFactory;

        public async Task<Player?> GetPlayerAsync(int id)
        {
            var httpClient = _httpClientFactory.CreateClient("NbaV1"); // REVISAR
            var httpResponseMessage = await httpClient.GetAsync("players"); // REVISAR

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

                return await JsonSerializer.DeserializeAsync<Player>(contentStream);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Player> GetPlayersTallerThan(int height)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Player> GetPlayersTallerThan215()
        {
            throw new NotImplementedException();
        }
    }
}
