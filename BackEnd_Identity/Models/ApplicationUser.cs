﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BackEnd_Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageName { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }


    }
}
