// <copyright file="Profile.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : Profile
// Author   : Julius Baltazar Jr
// Date     : 08/24/2024
// ================================================================
// Revision History
// dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

namespace BookClubManagementAPI.Entities
{
    public class Profile
    {
        public string? name { get; set; }
        public IEnumerable<string>? reading_preferences { get; set; }

    }
}
