// <copyright file="LoginRequest.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : LoginRequest
// Author   : Julius Baltazar Jr
// Date     : 08/24/2024
// ================================================================
// Revision History
// dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

using System.ComponentModel.DataAnnotations;

namespace BookClubManagementAPI.Dtos
{
    public class LoginRequest
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
