using Restaurant.Core.Application.Models_DTO.Ingredientes_DTO;

namespace Restaurant.Core.Application.ViewModels.Plato
{
    public class PlatoViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int CantidadPlatos { get; set; }
        public string Categoria { get; set; }
        public List<IngredienteDTO> Ingredientes { get; set; }
    }
}
