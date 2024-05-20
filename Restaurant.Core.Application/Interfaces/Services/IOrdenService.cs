using Restaurant.Core.Application.Models_DTO.Ordenes_DTO;
using Restaurant.Core.Application.ViewModels.Orden;
using Restaurant.Core.Domain.Entities;

namespace Restaurant.Core.Application.Interfaces.Services
{
    public interface IOrdenService : IGenericService<SaveOrdenViewModel, OrdenViewModel, Orden>
    {

    }
}
