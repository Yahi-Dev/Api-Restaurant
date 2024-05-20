using Restaurant.Core.Application.Models_DTO.Platos_DTO;

namespace Restaurant.Core.Application.ViewModels.Orden
{
    public class OrdenViewModel
    {
        public int Id { get; set; }
        public int MesaId { get; set; }
        public int Subtotal { get; set; }
        public string Estado { get; set; }
        public List<PlatoDTO> Platos { get; set; }
    }
}
