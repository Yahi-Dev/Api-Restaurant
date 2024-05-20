using System.ComponentModel.DataAnnotations;

namespace Restaurant.Core.Application.ViewModels.Mesa
{
    public class SaveMesaViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe colocar la capacidad max. de la mesa")]
        public int CantidadPersonas { get; set; }

        [Required(ErrorMessage = "Debe colocar una descripcion de la mesa")]
        public string Descripcion { get; set; }


        [Required(ErrorMessage = "Debe colocar el estado de la mesa")]
        public string Estado { get; set; }
    }
}
