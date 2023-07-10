using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.EntityConfiguration.SeedData.PropertyData
{
    public class SeedPropertyPlan : IEntityTypeConfiguration<PropertyPlan>
    {
        public void Configure(EntityTypeBuilder<PropertyPlan> builder)
        {
            builder.HasData(
                new PropertyPlan
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = true,
                    PlanImage = "IMG1.jpg",
                    PropertyId = 1,
                },
                new PropertyPlan
                {
                    Id = 2,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = true,
                    PlanImage = "IMG2.jpg",
                    PropertyId = 1,
                },
                new PropertyPlan
                {
                    Id = 3,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = true,
                    PlanImage = "IMG3.jpg",
                    PropertyId = 2,
                },
                new PropertyPlan
                {
                    Id = 4,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = true,
                    PlanImage = "IMG4.jpg",
                    PropertyId = 2,
                }
                );
        }
    }
}
