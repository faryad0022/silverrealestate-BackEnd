using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackEnd_Persistence.EntityConfiguration
{
    public class TeamMemberConfiguration : IEntityTypeConfiguration<TeamMember>
    {
        public void Configure(EntityTypeBuilder<TeamMember> builder)
        {
            builder.HasMany<TeamMemberSocial>(t => t.TeamMemberSocials)
                   .WithOne(t => t.TeamMember)
                   .HasForeignKey(t => t.TeamMemberId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
