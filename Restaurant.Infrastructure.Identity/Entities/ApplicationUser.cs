﻿using Microsoft.AspNetCore.Identity;

namespace Restaurant.Infrastructure.Identity.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
