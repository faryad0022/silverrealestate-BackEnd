using Domain.Entities.Blog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackEnd_Persistence.EntityConfiguration
{
    public class BlogGroupConfiguration : IEntityTypeConfiguration<BlogGroup>
    {
        public void Configure(EntityTypeBuilder<BlogGroup> builder)
        {
            builder.HasMany<BlogContent>(blogContent => blogContent.BlogContents)
                .WithOne(blogGroup => blogGroup.blogGroup)
                .HasForeignKey(blogContent => blogContent.BlogGroupId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
