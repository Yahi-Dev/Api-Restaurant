using Restaurant.Core.Application.Models_DTO.Platos_DTO;

namespace Restaurant.Core.Application.Models_DTO.Ordenes_DTO
{
    public class OrdenDTO
    {
        public int Id { get; set; }
        public int MesaId { get; set; }
        public int Subtotal { get; set; }
        public string Estado { get; set; }
        public List<PlatoDTO> Platos { get; set; }
    }
}
