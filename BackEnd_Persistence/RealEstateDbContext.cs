using Domain.Entities.Blog;
using Domain.Entities.GeneralSiteInformation;
using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_Persistence
{
    public class RealEstateDbContext : DbContext
    {

        public RealEstateDbContext(DbContextOptions<RealEstateDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RealEstateDbContext).Assembly);
        }


        public DbSet<BlogGroup> BlogGroups { get; set; }
        public DbSet<BlogContent> BlogContents { get; set; }


        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<CommonQuestion> CommonQuestions { get; set; }
        public DbSet<ConstructorInformation> ConstructorInformation { get; set; }
        public DbSet<RealEstateServices> RealEstateServices { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Spectacularlocation> Spectacularlocations { get; set; }
        public DbSet<SpectacularLocationImages> SpectacularLocationImages { get; set; }


        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<Facility> PropertyFacilities { get; set; }
        public DbSet<PropertyGallery> PropertyGalleries { get; set; }
        public DbSet<PropertyPlan> PropertyPlans { get; set; }
        public DbSet<PropertyVideo> PropertyVideos { get; set; }
        public DbSet<PropertyContractType> PropertyContractTypes { get; set; }

    }
}
