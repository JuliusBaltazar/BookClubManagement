// <copyright file="UserBookList.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : UserBookList
// Author   : Julius Baltazar Jr
// Date     : 08/24/2024
// ================================================================
// Revision History
// dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

namespace BookClubManagementAPI.Entities
{
    public class UserBookList
    {
        public int? user_id { get; set; }
        public IEnumerable<UserBook>? books { get; set;}
    }
}
