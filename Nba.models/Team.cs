

namespace Nba.Models
{
    public class Team
    {
        public class data
        {
            public int Id { get; set; }
            public string abbreviation { get; set; }
            public string city { get; set; }
            public string conference { get; set; }
            public string division { get; set; }
            public string full_name { get; set; }
            public string name { get; set; }
        }

        public class meta
        {
            public int total_pages { get; set; }
            public int current_page { get; set; }
            public int next_page { get; set; }
            public int per_page { get; set; }
            public int total_count { get; set; }
        }

    }
}
