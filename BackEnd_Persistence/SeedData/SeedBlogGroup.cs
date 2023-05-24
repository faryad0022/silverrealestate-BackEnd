using Domain.Entities.Blog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.SeedData
{
    public class SeedBlogGroup : IEntityTypeConfiguration<BlogGroup>
    {
        public void Configure(EntityTypeBuilder<BlogGroup> builder)
        {
            builder.HasData(
                new BlogGroup()
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    Name = "اخبار قبرس"
                },
                new BlogGroup()
                {
                    Id = 2,
                    CreateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    Name = "دانشگاه های قبرس"
                },
                new BlogGroup()
                {
                    Id = 3,
                    CreateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    Name = "کنسرت ها"
                }
                );
        }
    }
}
