using Application.Contract.Persistence;
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

            return _mockUOW;
        }
    }
}
