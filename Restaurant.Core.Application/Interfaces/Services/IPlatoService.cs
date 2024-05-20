using Restaurant.Core.Application.Models_DTO.Platos_DTO;
using Restaurant.Core.Application.ViewModels.Plato;
using Restaurant.Core.Domain.Entities;

namespace Restaurant.Core.Application.Interfaces.Services
{
    public interface IPlatoService : IGenericService<SavePlatoViewModel, PlatoViewModel, Plato>
    {

    }
}
