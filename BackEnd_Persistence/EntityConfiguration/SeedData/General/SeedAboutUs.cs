using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.EntityConfiguration.SeedData.General
{
    public class SeedAboutUs : IEntityTypeConfiguration<AboutUs>
    {
        public void Configure(EntityTypeBuilder<AboutUs> builder)
        {
            builder.HasData(
                new AboutUs
                {
                    Id = 1,
                    IsSelected = true,
                    CreateDate = DateTime.Now,
                    IsDelete = false,
                    Text = "املاک شبکه نقره ای با بیش از 6 سال سابقه درخشان آماده ی ارائه بهترین خدمات در راستای خرید ملک،سرمایه گذاری، اخذ اقامت، ثبت شرکت ، پذیرش دانشجویی و کلیه خدمات به همراه ارایه گشت های محلی با بکار گیری راهنمایان فارسی زبان بصورت گروهی و اختصاصی برای افراد و آژانسهای مسافرتی، به شما عزیزان در قبرس شمالی میباشد."
                }
                );
        }
    }
}
