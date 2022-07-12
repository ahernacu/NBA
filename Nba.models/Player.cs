using Newtonsoft.Json;

namespace Nba.models
{
    public class Player
    {
        
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("first_name")]
            public string FirstName { get; set; }
            [JsonProperty("last_name")]
            public string LastName { get; set; }
            [JsonProperty("position")]
            public string Position { get; set; }
            [JsonProperty("height_feet")]
            public int? HeightFeet { get; set; }
            [JsonProperty("height_inches")]
            public int? HeightInches { get; set; }
            [JsonProperty("weight_pounds")]
            public int? WeightPounds { get; set; }

    }
}