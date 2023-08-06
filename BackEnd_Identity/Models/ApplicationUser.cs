﻿using Microsoft.AspNetCore.Identity;

namespace BackEnd_Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageName { get; set; }

    }
}
