// <copyright file="IBookService.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : IBookService
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
    public interface IBookService
    {
        Task<Book?> GetBook(int id);

        Task<IEnumerable<Book>?> SearchBook(SearchBookParameter searchParam);
    }
}
