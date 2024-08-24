namespace BookClubManagementAPI.Entities
{
    public class DiscussionThread
    {
        public int? id { get; set; }
        public int? book_club_id { get; set; }
        public string? title { get; set; }
        public int? author_id { get; set; }
        public IEnumerable<Post>? Posts { get; set; }
    }
}
