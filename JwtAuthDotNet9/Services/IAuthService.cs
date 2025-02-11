using JwtAuthDotNet9.Entities;
using JwtAuthDotNet9.Models;

namespace JwtAuthDotNet9.Services
{
    public interface IAuthService
    {
        Task<User?>  RegisterAsync(UserDto userDto);
        Task<TokenResponseDto?> LoginAsync(UserDto userDto);
        Task<TokenResponseDto?> RefreshTokenAsync(RefreshTokenRequestDto request);

    }
}
