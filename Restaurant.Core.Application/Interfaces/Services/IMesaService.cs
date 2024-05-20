using Restaurant.Core.Application.Models_DTO.Mesas_DTO;
using Restaurant.Core.Application.ViewModels.Mesa;
using Restaurant.Core.Application.ViewModels.Orden;
using Restaurant.Core.Domain.Entities;

namespace Restaurant.Core.Application.Interfaces.Services
{
    public interface IMesaService : IGenericService<SaveMesaViewModel, MesaViewModel, Mesa>
    {
        Task<bool> ChangeStatus(ChangeStatusMesaViewModel vm);
        Task<List<OrdenViewModel>> GetTableOrden(int MesaId);
    }
}
