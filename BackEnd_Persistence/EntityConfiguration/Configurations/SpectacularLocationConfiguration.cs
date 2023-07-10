using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackEnd_Persistence.EntityConfiguration.Configurations
{
    public class SpectacularLocationConfiguration : IEntityTypeConfiguration<Spectacularlocation>
    {
        public void Configure(EntityTypeBuilder<Spectacularlocation> builder)
        {
            builder.HasMany<SpectacularLocationImages>(si => si.spectacularLocationImages)
                   .WithOne(sl => sl.Spectacularlocation)
                   .HasForeignKey(s => s.SpectacularlocationId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
