using AutoMapper;
using Restaurant.Core.Application.Dtos.Account;
using Restaurant.Core.Application.Interfaces.Services;
using Restaurant.Core.Application.ViewModels.Users;

namespace Restaurant.Core.Application.NewFolder
{
    public class UserService : IUserService
    {
        private readonly IAccountService _accountservice;
        private readonly IMapper _mapper;

        public UserService(
            IAccountService accountservice,
            IMapper mapper)
        {
            _accountservice = accountservice;
            _mapper = mapper;
        }


        public async Task<AuthenticationResponse> LoginAsync(LoginDTO vm)
        {
            AuthenticationRequest loginrequest = _mapper.Map<AuthenticationRequest>(vm);

            AuthenticationResponse userResponse = await _accountservice.AuthenticateAsync(loginrequest);
            return userResponse;
        }


        public async Task SignOutAsync()
        {
            await _accountservice.SignOutAsync();
        }


        public async Task<RegisterResponse> RegisterAsync(SaveUserDTO vm, string origin)
        {
            RegisterRequest registerRequest = _mapper.Map<RegisterRequest>(vm);
            return await _accountservice.RegisterBasicUserAsync(registerRequest, origin);
        }
    }
}