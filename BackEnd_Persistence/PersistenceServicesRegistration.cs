
using Application.Contract.Persistance.EntitiesRepository.Blog;
using Application.Contract.Persistence;
using Application.Contract.Persistence.CommonGenericRepository;
using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using BackEnd_Persistence.Repositories;
using BackEnd_Persistence.Repositories.Blogs;
using BackEnd_Persistence.Repositories.GeneralInformations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BackEnd_Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<RealEstateDbContext>(options =>
            {
                //options.EnableSensitiveDataLogging();
                options.UseSqlServer(configuration.GetConnectionString("RealEstateDbContext"));
            });
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitofWork, UnitOfWork>();

            services.AddScoped<IBlogContentRepository, BlogContentRepository>();
            services.AddScoped<IBlogGroupRepository, BlogGroupRepository>();
            services.AddScoped<IAboutUsRepository, AboutUsRepository>();
            services.AddScoped<ISocialRepository, SocialRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ILogoRepository, LogoRepository>();
            services.AddScoped<IBannerRepository, BannerRepository>();
            services.AddScoped<ICommonQuestionRepository, CommonQuestionRepository>();
            services.AddScoped<IConstructorInfromationRepository, ConstructorInfromationRepository>();
            services.AddScoped<IRealEstateServicesRepository, RealEstateServicesRepository>();



            return services;
        }
    }
}
