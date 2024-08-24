// <copyright file="DiscussionThread.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : DiscussionThread
// Author   : Julius Baltazar Jr
// Date     : 08/24/2024
// ================================================================
// Revision History
// dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

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
