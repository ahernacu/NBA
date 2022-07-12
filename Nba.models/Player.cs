using System.Text.Json.Serialization;

namespace Nba.models
{
    public class Player
    {
        
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }

        //[JsonPropertyName("height_feet")]
        //public int? HeightFeet { get; set; }

        //[JsonPropertyName("height_inches")]
        //public int? HeightInches { get; set; }

        //[JsonPropertyName("weight_pounds")]
        //public int? WeightPounds { get; set; }

    }
}