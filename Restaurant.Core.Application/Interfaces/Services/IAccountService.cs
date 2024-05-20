using Restaurant.Core.Application.Dtos.Account;

namespace Restaurant.Core.Application.Interfaces.Services
{
    public interface IAccountService
    {
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
        Task<RegisterResponse> RegisterBasicUserAsync(RegisterRequest request, string origin);
        Task<RegisterResponse> RegisterAdminUserAsync(RegisterRequest request, string origin);
        Task SignOutAsync();
    }
}