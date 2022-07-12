using Nba.Models;
using Nba.Services.Interfaces;
using System.Text.Json;

namespace Nba.Services.Implementations
{
    public class TeamService : ITeamService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TeamService(IHttpClientFactory httpClientFactory) =>
            _httpClientFactory = httpClientFactory;

        public async Task<Team?> GetTeamAsync(int id)
        {
            var httpClient = _httpClientFactory.CreateClient("Nba"); // REVISAR
            var httpResponseMessage = await httpClient.GetAsync("teams"); // REVISAR

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

                return await JsonSerializer.DeserializeAsync<Team>(contentStream);
            }
            else
            {
                return null;
            }
        }
    }
}
