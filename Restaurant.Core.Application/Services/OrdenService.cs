using AutoMapper;
using Microsoft.AspNetCore.Http;
using Restaurant.Core.Application.Dtos.Account;
using Restaurant.Core.Application.Interfaces.Repositories;
using Restaurant.Core.Application.Interfaces.Services;
using Restaurant.Core.Application.Helpers;
using Restaurant.Core.Domain.Entities;
using Restaurant.Core.Application.ViewModels.Orden;

namespace Restaurant.Core.Application.Services
{
    public class OrdenService : GenericService <SaveOrdenViewModel, OrdenViewModel, Orden>, IOrdenService
    {
        private readonly IOrdenRepository _OrdenRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationResponse _userViewModel;
        private readonly IMapper _mapper;

        public OrdenService(
            IOrdenRepository ordenRepository,
            IMapper mapper,
            IHttpContextAccessor httpContextAccessor)
            : base(ordenRepository, mapper)
        {
            _OrdenRepository = ordenRepository;
            _httpContextAccessor = httpContextAccessor;
            _userViewModel = httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>("user");
            _mapper = mapper;
        }
    }
}
