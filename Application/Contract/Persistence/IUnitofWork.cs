using Application.Contract.Persistance.EntitiesRepository.Blog;
using Application.Contract.Persistance.EntitiesRepository.Project;
using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using Application.Contract.Persistence.EntitiesRepository.Project;
using System;
using System.Threading.Tasks;

namespace Application.Contract.Persistence
{
    public interface IUnitofWork : IDisposable
    {
        ISocialRepository SocialRepository { get; }
        IBlogContentRepository BlogContentRepository { get; }
        IBlogGroupRepository BlogGroupRepository { get; }
        IAboutUsRepository AboutUsRepository { get; }
        IAddressRepository AddressRepository { get; }
        ILogoRepository LogoRepository { get; }
        IBannerRepository BannerRepository { get; }
        ICommonQuestionRepository CommonQuestionRepository { get; }
        IConstructorInfromationRepository ConstructorInfromationRepository { get; }
        IRealEstateServicesRepository RealEstateServicesRepository { get; }
        ISpectacularlocationRepository SpectacularlocationRepository { get; }
        ISpectacularLocationImageRepository SpectacularLocationImageRepository { get; }
        ITeamMemberRepository TeamMemberRepository { get; }

        ICityRepository CityRepository { get; }
        ICountryRepository CountryRepository { get; }
        IPropertyContractTypeRepository PropertyContractTypeRepository { get; }
        IPropertyTypeRepository PropertyTypeRepository { get; }
        IPropertyPlanRepository PropertyPlanRepository { get; }
        Task SaveChangesAsync();
    }
}
