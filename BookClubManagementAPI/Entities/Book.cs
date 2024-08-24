// <copyright file="Book.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : Book
// Author   : Julius Baltazar Jr
// Date     : 08/24/2024
// ================================================================
// Revision History
// dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

namespace BookClubManagementAPI.Entities
{
    public class Book
    {
        public int? id { get; set; }
        public string? title { get; set; }
        public string? author { get; set; }
        public string? genre { get; set; }
        public string? cover_image { get; set; }        

    }
}
