// <copyright file="IClubService.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : IClubService
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
    public interface IClubService
    {
        Task<Club?> GetClub(int id);
        Task<IEnumerable<DiscussionThread>?> GetForum(int id);
    }
}
