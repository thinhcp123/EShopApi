using EShopApi.DTOs;

namespace EShopApi.Services.Account
{
    public interface IAccountServices
    {
        Task<string> GenerateToken(User user);
        Task<string> RegisterAsync(RegisterDto registerDto);

    }
}
