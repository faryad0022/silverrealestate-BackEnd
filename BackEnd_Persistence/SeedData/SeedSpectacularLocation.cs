using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackEnd_Persistence.SeedData
{
    public class SeedSpectacularLocation : IEntityTypeConfiguration<SeedSpectacularLocation>
    {
        public void Configure(EntityTypeBuilder<SeedSpectacularLocation> builder)
        {
            builder.HasData(
                new Spectacularlocation()
                {
                    Id = 1,
                    IsSelected = true,
                    Name = "Ghost City"
                },
                new Spectacularlocation()
                {
                    Id = 2,
                    IsSelected = true,
                    Name = "Wall City"
                },
                new Spectacularlocation()
                {
                    Id = 3,
                    IsSelected = false,
                    Name = "Long Beach"
                },
                new Spectacularlocation()
                {
                    Id = 4,
                    IsSelected = false,
                    Name = "Casino"
                }
                );
        }
    }
}
