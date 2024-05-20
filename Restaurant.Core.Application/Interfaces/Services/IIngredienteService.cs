using Restaurant.Core.Application.Models_DTO.Ingredientes_DTO;
using Restaurant.Core.Application.ViewModels.Ingredientes;
using Restaurant.Core.Domain.Entities;

namespace Restaurant.Core.Application.Interfaces.Services
{
    public interface IIngredienteService : IGenericService<SaveIngredientesViewModel, IngredientesViewModel, Ingredientes>
    {

    }
}
