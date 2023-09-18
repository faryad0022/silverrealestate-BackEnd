using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BackEnd_Identity.Models
{
    public class ApplicationRole : IdentityRole
    {
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
