using AutoMapper;
using Microsoft.AspNetCore.Http;
using Restaurant.Core.Application.Dtos.Account;
using Restaurant.Core.Application.Interfaces.Repositories;
using Restaurant.Core.Application.Interfaces.Services;
using Restaurant.Core.Application.Models_DTO.Ingredientes_DTO;
using Restaurant.Core.Domain.Entities;
using Restaurant.Core.Application.Helpers;
using Restaurant.Core.Application.ViewModels.Ingredientes;

namespace Restaurant.Core.Application.Services
{
    public class IngredienteService : GenericService<SaveIngredientesViewModel, IngredientesViewModel, Ingredientes>, IIngredienteService
    {
        private readonly IIngredientesRepository _ingredienteRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationResponse _userViewModel;
        private readonly IMapper _mapper;

        public IngredienteService(
            IIngredientesRepository ingredienteRepository,
            IMapper mapper,
            IHttpContextAccessor httpContextAccessor)
            : base(ingredienteRepository, mapper)
        {
            _ingredienteRepository = ingredienteRepository;
            _httpContextAccessor = httpContextAccessor;
            _userViewModel = httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>("user");
            _mapper = mapper;
        }
    }
}
