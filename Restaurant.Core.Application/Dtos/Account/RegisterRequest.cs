﻿namespace Restaurant.Core.Application.Dtos.Account
{
    public class RegisterRequest
    {
        public string FirstName { get; set; }
        public string LastName {  get; set; }
        public string Email { get; set; }
        public string UserName { get; set; } 
        public string password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Phone {  get; set; }
    }
}
