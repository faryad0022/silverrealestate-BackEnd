using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.features.GeneralInformations.SpectacularLocationImageFeatures.Handler.Commands;
using Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.SpectacularImages.Commands
{
    public class ChangeSpectacularLocationImageSelectedStatusRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitOfWork;
        public ChangeSpectacularLocationImageSelectedStatusRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task ChangeSpectacularLocationImage_Valid()
        {
            var handler = new ChangeSpectacularLocationImageSelectedStatusRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new ChangeSpectacularLocationImageSelectedStatusRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Errors.ShouldBeNull();
            result.Tentity.ShouldNotBeNull();
            result.Tentities.ShouldBeNull();
            result.Tentity.ShouldBeOfType(typeof(SpectacularLocationImagesDTO));
        }
        [Fact]
        public async Task CreateSpectacularLocationImage_NotFound_InValid()
        {
            var handler = new ChangeSpectacularLocationImageSelectedStatusRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new ChangeSpectacularLocationImageSelectedStatusRequest() { Id = 11 }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.NotFound);
            result.Errors.ShouldBeNull();
            result.Tentity.ShouldBeNull();
            result.Tentities.ShouldBeNull();
        }
    }
}
