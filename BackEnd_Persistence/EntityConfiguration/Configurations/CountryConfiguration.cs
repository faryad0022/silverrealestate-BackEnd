using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackEnd_Persistence.EntityConfiguration.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasMany<City>(city => city.Cities)
                .WithOne(country => country.Country)
                .HasForeignKey(country => country.CountryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
