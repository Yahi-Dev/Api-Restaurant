using AutoMapper;
using Microsoft.AspNetCore.Http;
using Restaurant.Core.Application.Dtos.Account;
using Restaurant.Core.Application.Interfaces.Repositories;
using Restaurant.Core.Application.Interfaces.Services;
using Restaurant.Core.Application.Helpers;
using Restaurant.Core.Domain.Entities;
using Restaurant.Core.Application.ViewModels.Mesa;
using Restaurant.Core.Application.ViewModels.Orden;

namespace Restaurant.Core.Application.Services
{
    public class MesaService : GenericService<SaveMesaViewModel, MesaViewModel,Mesa>, IMesaService
    {
        private readonly IMesaRepository _mesaRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationResponse _userViewModel;
        private readonly IMapper _mapper;
        private readonly IOrdenService _ordenService;

        public MesaService(IMesaRepository mesaRepository,
            IMapper mapper,
            IHttpContextAccessor httpContextAccessor,
            IOrdenService ordenService) 
            : base(mesaRepository, mapper)
        {
            _mesaRepository = mesaRepository;
            _httpContextAccessor = httpContextAccessor;
            _userViewModel = httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>("user");
            _mapper = mapper;
            _ordenService = ordenService;
        }

        public async Task<bool> ChangeStatus(ChangeStatusMesaViewModel vm)
        {
            try
            {
                var mesa = await _mesaRepository.GetById(vm.MesaId);
                mesa.Estado = vm.StatusMesa;
                await _mesaRepository.UpdateAsync(mesa, mesa.Id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<OrdenViewModel>> GetTableOrden(int MesaId)
        {
            var ordenes = await _ordenService.GetAllViewModel();
            var ordenesVm = ordenes.Where(o => o.MesaId == MesaId).ToList();
            return ordenesVm;
        }
    }
}
