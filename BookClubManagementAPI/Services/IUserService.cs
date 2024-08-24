using BookClubManagementAPI.Entities;

namespace BookClubManagementAPI.Services
{
    public interface IUserService
    {
        Task<User?> GetUser(int id);
    }
}
