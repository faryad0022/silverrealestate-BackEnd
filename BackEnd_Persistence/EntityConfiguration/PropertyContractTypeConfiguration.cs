using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackEnd_Persistence.EntityConfiguration
{
    public class PropertyContractTypeConfiguration : IEntityTypeConfiguration<PropertyContractType>
    {
        public void Configure(EntityTypeBuilder<PropertyContractType> builder)
        {
            builder.HasMany(property => property.Properties)
                .WithOne(propertyContractType => propertyContractType.PropertyContractType)
                .HasForeignKey(propertyContractType => propertyContractType.PropertyContractTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
