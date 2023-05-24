using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.SeedData
{
    public class SeedBanner : IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
        {
            builder.HasData(
                new Banner
                {
                    Id = 1,
                    Header = "آفرهای ویژه",
                    PhoneLogo = "phone.jpg",
                    RealEstateLogo = "silver.jpg",
                    ShortText = "تا فرصت هست از آفرهای ویژه شرکت استفاده کنید",
                    Text = "با خرید ملک مبلمان رایگان دریافت کنید",
                    CreateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    Description = "تا پایان خرداد"
                }
                );
        }
    }
}
