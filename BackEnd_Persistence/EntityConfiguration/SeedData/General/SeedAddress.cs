using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.EntityConfiguration.SeedData.General
{
    public class SeedAddress : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasData(
                new Address
                {
                    Id = 1,
                    CellPhone = "+98-9123071411",
                    Email = "mahancomputer49@gmail.com",
                    Location = "کیش - شهرک صدف - خیابان سبلان - پلاک 27 - واحد6",
                    Telephone = "00987644446503",
                    WorkHour = "شنبه تا جمعه ساعت 8-20",
                    CreateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = false
                },
                new Address
                {
                    Id = 2,
                    CellPhone = "+90-5338355243",
                    Email = "mahancomputer49@gmail.com",
                    Location = "قبرس شمالی - شهرک رویال سان - پرل 105",
                    Telephone = "00987644446503",
                    WorkHour = "شنبه تا جمعه ساعت 8-20",
                    CreateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = false
                }

                );
        }
    }
}
