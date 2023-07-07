using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.SpectacularLocationImageFeatures.Handler.Commands;
using Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.General.SoectacularImages;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.General.SpectacularImages.Commands
{
    public class UpdateSpectacularLocationImageRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitOfWork;
        public UpdateSpectacularLocationImageRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task UpdateSpectacularLocationImage_Valid()
        {
            var handler = new UpdateSpectacularLocationImageRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new UpdateSpectacularLocationImageRequest() { updateSpectacularLocationImagesDTO = SpectacularLocationImageModelGenerator.updateSpectacularImags_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();


        }
        [Fact]
        public async Task UpdateSpectacularLocationImage_ValidationError_InValid()
        {
            var handler = new UpdateSpectacularLocationImageRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new UpdateSpectacularLocationImageRequest() { updateSpectacularLocationImagesDTO = SpectacularLocationImageModelGenerator.updateSpectacularImags_ValidationError_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();


        }
        [Fact]
        public async Task UpdateSpectacularLocationImage_NotFound_InValid()
        {
            var handler = new UpdateSpectacularLocationImageRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new UpdateSpectacularLocationImageRequest() { updateSpectacularLocationImagesDTO = SpectacularLocationImageModelGenerator.updateSpectacularImags_NotFound_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();


        }
        [Fact]
        public async Task UpdateSpectacularLocationImage_MustSelectedParent_ValidationError_InValid()
        {
            var handler = new UpdateSpectacularLocationImageRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new UpdateSpectacularLocationImageRequest() { updateSpectacularLocationImagesDTO = SpectacularLocationImageModelGenerator.updateSpectacularImags_MustSelected_ValidationError_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();


        }
    }
}
