using Nba.models;
using Newtonsoft.Json;

namespace Nba.Models
{
    public class PaginationWrapper
    {
        [JsonProperty("data")]
        public Player Data { get; set; }

        [JsonProperty("meta")]
        public PaginationOptions Meta { get; set; }
    }

    public class PaginationOptions
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }
}
