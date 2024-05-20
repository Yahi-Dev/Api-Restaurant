using Restaurant.Core.Application.Dtos.Account;
using Restaurant.Core.Application.ViewModels.Users;

namespace Restaurant.Core.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<AuthenticationResponse> LoginAsync(LoginDTO vm);
        Task<RegisterResponse> RegisterAsync(SaveUserDTO vm, string origin);
        Task SignOutAsync();
    }
}