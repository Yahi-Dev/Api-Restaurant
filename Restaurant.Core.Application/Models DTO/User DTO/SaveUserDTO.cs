﻿using System.ComponentModel.DataAnnotations;


namespace Restaurant.Core.Application.ViewModels.Users
{
    public class SaveUserDTO
    {
        [Required(ErrorMessage = "Debe colocar el nombre del usuario")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }




        [Required(ErrorMessage = "Debe colocar el apellido del usuario")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }





        [Required(ErrorMessage = "Debe colocar el nombre del usuario")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }





        [Required(ErrorMessage = "Debe colocar una contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }





        [Compare(nameof(Password), ErrorMessage ="Las Contraseñas deben coincidir")]
        [Required(ErrorMessage = "Debe colocar el nombre del usuario")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        



        [Required(ErrorMessage = "Debe colocar un correo")]
        [DataType(DataType.Text)]
        public string Email { get; set; }





        [Required(ErrorMessage = "Debe colocar un telefono")]
        [DataType(DataType.Text)]
        public string Phone { get; set; }





        public string? Error { get; set; }
        public bool HasError { get; set; }
    }
}
