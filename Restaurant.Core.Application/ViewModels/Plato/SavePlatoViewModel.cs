using Restaurant.Core.Application.Models_DTO.Ingredientes_DTO;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Core.Application.ViewModels.Plato
{
    public class SavePlatoViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe colocar el nombre del plato")]
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int CantidadPlatos { get; set; }
        public string Categoria { get; set; }
        public List<IngredienteDTO> Ingredientes { get; set; }
    }
}
