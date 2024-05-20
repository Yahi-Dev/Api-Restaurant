using Restaurant.Core.Application.Models_DTO.Platos_DTO;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Core.Application.ViewModels.Orden
{
    public class SaveOrdenViewModel
    {
        public int Id { get; set; }
        public int MesaId { get; set; }
        public int Subtotal { get; set; }

        [Required(ErrorMessage = "Debe colocar el estado de la orden")]
        public string Estado { get; set; }
        public List<PlatoDTO> Platos { get; set; }
    }
}
