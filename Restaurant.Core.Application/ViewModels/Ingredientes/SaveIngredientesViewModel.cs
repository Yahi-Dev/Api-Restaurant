using System.ComponentModel.DataAnnotations;

namespace Restaurant.Core.Application.ViewModels.Ingredientes
{
    public class SaveIngredientesViewModel
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Debe colocar el nombre del ingrediente")]
        public string Name { get; set; }
    }
}
