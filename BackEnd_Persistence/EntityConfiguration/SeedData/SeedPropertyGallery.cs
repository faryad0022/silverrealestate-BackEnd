using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.EntityConfiguration.SeedData
{
    public class SeedPropertyGallery : IEntityTypeConfiguration<PropertyGallery>
    {
        public void Configure(EntityTypeBuilder<PropertyGallery> builder)
        {
            builder.HasData(
                new PropertyGallery
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    ImageName = "IMG1.jpg",
                    PropertyId = 1,

                },
                new PropertyGallery
                {
                    Id = 2,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    ImageName = "IMG2.jpg",
                    PropertyId = 1,

                },
                new PropertyGallery
                {
                    Id = 3,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    ImageName = "IMG3.jpg",
                    PropertyId = 1,

                },
                new PropertyGallery
                {
                    Id = 4,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    ImageName = "IMG4.jpg",
                    PropertyId = 1,

                },
                new PropertyGallery
                {
                    Id = 5,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    ImageName = "IMG5.jpg",
                    PropertyId = 2,

                },
                new PropertyGallery
                {
                    Id = 6,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    ImageName = "IMG6.jpg",
                    PropertyId = 2,

                },
                new PropertyGallery
                {
                    Id = 7,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    ImageName = "IMG7.jpg",
                    PropertyId = 2,

                }
                );
        }
    }
}
