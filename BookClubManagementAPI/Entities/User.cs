// <copyright file="User.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : User
// Author   : Julius Baltazar Jr
// Date     : 08/24/2024
// ================================================================
// Revision History
// dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

namespace BookClubManagementAPI.Entities
{
    public class User
    {
        public int? id { get; set; }
        public string? username { get; set; }
        
        public string? email { get; set; }
        
        public string? password { get; set; }

        public Profile? profile { get; set; }
    }
}
