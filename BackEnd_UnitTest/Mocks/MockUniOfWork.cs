using Application.Contract.Persistence;
using BackEnd_UnitTest.Mocks.Blog;
using BackEnd_UnitTest.Mocks.General;
using BackEnd_UnitTest.Mocks.Projects;
using Moq;

namespace BackEnd_UnitTest.Mocks
{
    public static class MockUniOfWork
    {
        public static Mock<IUnitofWork> GetMockUnitOfWork()
        {
            var _mockUOW = new Mock<IUnitofWork>();
            var _moclSocialRepository = MockSocialRepository.GetSocialRepository();
            var _mockBlogGroupRepository = MockBlogGroupRepository.GetBlogGroupRepository_Mock();
            var _mockBlogContentRepository = MockBlogContentRepository.GetBlogContentRepository();
            var _mockAddressRepository = MockAddressRepository.GetAddressRepository();
            var _mockLogoRepository = MockLogoRepository.GetLogoRepository();
            var _mockBannerRepository = MockBannerRepository.GetBannerRepository();
            var _mockAboutUsRepository = MockAboutUsRepository.GetAboutUsRepository();
            var _mockCommonQuestionRepository = MockCommonQuestionRepository.GetCommonQuestionRepository();
            var _mockConstructorInformationRepository = MockConstructorInformationRepository.GetConstructorInformationRepository();
            var _mockrRealEstateServiceepository = MockRealEstateServices.GetRealEstateServicesRepository();
            var _mockrSpectacularLocationRepository = MockSpectacularLocationRepository.GetSpectacularLocationRepositories();
            var _mockrSpectacularLocationImagesRepository = MockSpectacularImagesRepository.GetSpectacularImagesRepository();
            var _mockTeamMemberRepository = MockTeamMemberRepository.GetTeamMemberRepository();
            var _mockCountryRepository = MockCountryRepository.GetCountryRepository();
            var _mockCityRepository = MockCityRepository.GetCityRepository();
            var _mockPropertyTypeRepository = MockPropertyTypeRepository.GetPropertyTypeRepository();
            var _mockPropertyContractTypeRepository = MockPropertyContractTypeRepository.GetPropertyContractTypeRepository();
            var _mockPropertyRepository = MockPropertyRepository.GetPropertyRepository();


            //var _mockAboutSocialRepository = Mock
            _mockUOW.Setup(s => s.BlogGroupRepository).Returns(() => _mockBlogGroupRepository.Object);
            _mockUOW.Setup(s => s.BlogContentRepository).Returns(() => _mockBlogContentRepository.Object);
            _mockUOW.Setup(s => s.SocialRepository).Returns(() => _moclSocialRepository.Object);
            _mockUOW.Setup(s => s.AddressRepository).Returns(() => _mockAddressRepository.Object);
            _mockUOW.Setup(s => s.LogoRepository).Returns(() => _mockLogoRepository.Object);
            _mockUOW.Setup(s => s.BannerRepository).Returns(() => _mockBannerRepository.Object);
            _mockUOW.Setup(s => s.AboutUsRepository).Returns(() => _mockAboutUsRepository.Object);
            _mockUOW.Setup(s => s.CommonQuestionRepository).Returns(() => _mockCommonQuestionRepository.Object);
            _mockUOW.Setup(s => s.ConstructorInfromationRepository).Returns(() => _mockConstructorInformationRepository.Object);
            _mockUOW.Setup(s => s.RealEstateServicesRepository).Returns(() => _mockrRealEstateServiceepository.Object);
            _mockUOW.Setup(s => s.SpectacularlocationRepository).Returns(() => _mockrSpectacularLocationRepository.Object);
            _mockUOW.Setup(s => s.SpectacularLocationImageRepository).Returns(() => _mockrSpectacularLocationImagesRepository.Object);
            _mockUOW.Setup(s => s.TeamMemberRepository).Returns(() => _mockTeamMemberRepository.Object);
            _mockUOW.Setup(s => s.CountryRepository).Returns(() => _mockCountryRepository.Object);
            _mockUOW.Setup(s => s.CityRepository).Returns(() => _mockCityRepository.Object);
            _mockUOW.Setup(s => s.PropertyTypeRepository).Returns(() => _mockPropertyTypeRepository.Object);
            _mockUOW.Setup(s => s.PropertyContractTypeRepository).Returns(() => _mockPropertyContractTypeRepository.Object);
            _mockUOW.Setup(s => s.PropertyRepository).Returns(() => _mockPropertyRepository.Object);


            return _mockUOW;
        }
    }
}
