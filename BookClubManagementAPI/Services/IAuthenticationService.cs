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
