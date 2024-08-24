using BookClubManagementAPI.Entities;

namespace BookClubManagementAPI.Services
{
    public interface IBookService
    {
        Task<Book?> GetBook(int id);

        Task<IEnumerable<Book>?> SearchBook(SearchBookParameter searchParam);
    }
}
