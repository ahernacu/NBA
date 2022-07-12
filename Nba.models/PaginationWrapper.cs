using Nba.models;
using System.Text.Json.Serialization;

namespace Nba.Models
{
    public class PaginationWrapper
    {
        [JsonPropertyName("data")]
        public Player Data { get; set; }

        [JsonPropertyName("meta")]
        public PaginationOptions Meta { get; set; }
    }

    public class PaginationOptions
    {
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("current_page")]
        public int CurrentPage { get; set; }

        [JsonPropertyName("next_page")]
        public int NextPage { get; set; }

        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }

        [JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
