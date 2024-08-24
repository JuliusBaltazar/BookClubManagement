// <copyright file="IUserService.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : IUserService
// Author   : Julius Baltazar Jr
// Date     : 08/24/2024
// ================================================================
// Revision History
// dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

using BookClubManagementAPI.Entities;

namespace BookClubManagementAPI.Services
{
    public interface IUserService
    {
        Task<User?> GetUser(int id);
        Task<UserBookList?> GetUserBooks(int id);
    }
}
