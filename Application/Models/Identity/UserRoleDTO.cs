using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Models.Identity
{
    public class UserRoleDTO
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string UserName { get; set; }
    }
}
