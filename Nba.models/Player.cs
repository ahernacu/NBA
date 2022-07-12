

namespace Nba.models
{
    public class Player
    {
        public class data
        {
            public int Id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string position { get; set; }
            public string height_feet { get; set; }
            public string height_inches { get; set; }
            public string weigth_pounds { get; set; }
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