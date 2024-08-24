using BookClubManagementAPI.Entities;

namespace BookClubManagementAPI.Services
{
    public interface IClubService
    {
        Task<Club?> GetClub(int id);
    }
}
