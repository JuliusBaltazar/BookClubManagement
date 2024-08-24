

namespace BookClubManagementAPI.Entities
{
    public class Club
    {
        public int? id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public IEnumerable<int>? members { get; set; }
    }
}
