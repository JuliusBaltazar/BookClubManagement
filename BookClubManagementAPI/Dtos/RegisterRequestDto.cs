// <copyright file="RegisterRequest.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : RegisterRequest
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
    public class RegisterRequest
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
