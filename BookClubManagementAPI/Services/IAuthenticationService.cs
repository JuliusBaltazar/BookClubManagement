// <copyright file="IAuthenticationService.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : IAuthenticationService
// Author   : Julius Baltazar Jr
// Date     : 08/24/2024
// ================================================================
// Revision History
// dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

using System.IdentityModel.Tokens.Jwt;
using BookClubManagementAPI.Dtos;

namespace BookClubManagementAPI.Services
{
    public interface IAuthenticationService
    {
        Task<string> Register(RegisterRequest request);
        Task<string> Login(LoginRequest request);
    }
}
