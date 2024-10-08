﻿// <copyright file="Club.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : Club
// Author   : Julius Baltazar Jr
// Date     : 08/24/2024
// ================================================================
// Revision History
// dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

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
