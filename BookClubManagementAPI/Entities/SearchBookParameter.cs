// <copyright file="SearchBookParameter.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : SearchBookParameter
// Author   : Julius Baltazar Jr
// Date     : 08/24/2024
// ================================================================
// Revision History
// dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

namespace BookClubManagementAPI.Entities
{
    public class SearchBookParameter
    {
        public string? title { get; set; }
        public string? author { get; set; }
        public string? genre { get; set; }
    }
}
