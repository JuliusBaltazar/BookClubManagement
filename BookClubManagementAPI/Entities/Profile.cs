namespace BookClubManagementAPI.Entities
{
    public class Profile
    {
        public string? name { get; set; }
        public IEnumerable<string>? reading_preferences { get; set; }

    }
}
