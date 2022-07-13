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

        public async Task<Team?> GetTeamAsync(int teamId)
        {
            var httpClient = _httpClientFactory.CreateClient("NbaV1"); // REVISAR
            var httpResponseMessage = await httpClient.GetAsync($"teams/{teamId}"); // REVISAR

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();
                var team = await JsonSerializer.DeserializeAsync<Team>(contentStream);
                return team;
            }
            else
            {
                return null;
            }
        }
    }
}