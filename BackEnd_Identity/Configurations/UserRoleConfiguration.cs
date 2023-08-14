using BackEnd_Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<ApplicationUserRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserRole> builder)
        {
            builder.HasData(
                new ApplicationUserRole
                {
                    RoleId = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                },
                new ApplicationUserRole
                {
                    RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                    UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9"
                }
            );
        }
    }
}
