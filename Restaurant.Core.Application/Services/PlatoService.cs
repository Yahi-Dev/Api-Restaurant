using AutoMapper;
using Microsoft.AspNetCore.Http;
using Restaurant.Core.Application.Dtos.Account;
using Restaurant.Core.Application.Interfaces.Repositories;
using Restaurant.Core.Application.Interfaces.Services;
using Restaurant.Core.Application.Helpers;
using Restaurant.Core.Domain.Entities;
using Restaurant.Core.Application.ViewModels.Plato;

namespace Restaurant.Core.Application.Services
{
    public class PlatoService : GenericService <SavePlatoViewModel, PlatoViewModel, Plato>, IPlatoService
    {
        private readonly IPlatoRepository _PlatoRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationResponse _userViewModel;
        private readonly IMapper _mapper;

        public PlatoService(
            IPlatoRepository platoRepository,
            IMapper mapper,
            IHttpContextAccessor httpContextAccessor)
            : base(platoRepository, mapper)
        {
            _PlatoRepository = platoRepository;
            _httpContextAccessor = httpContextAccessor;
            _userViewModel = httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>("user");
            _mapper = mapper;
        }
    }
}
