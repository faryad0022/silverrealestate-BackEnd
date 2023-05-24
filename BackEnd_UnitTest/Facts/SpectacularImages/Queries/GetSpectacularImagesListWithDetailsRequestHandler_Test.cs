using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.SpectacularLocationImageFeatures.Handler.Queries;
using Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.SpectacularImages.Queries
{
    public class GetSpectacularImagesListWithDetailsRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitOfWork;
        public GetSpectacularImagesListWithDetailsRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetSpectacularImagesListWithDetails_Valid()
        {
            var handler = new GetSpectacularImagesListWithDetailsRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new GetSpectacularImagesListWithDetailsRequest(), CancellationToken.None);

            result.Errors.ShouldBeNull();
            result.Tentities.Count.ShouldBe(5);
            result.Tentity.ShouldBeNull();
            result.Status.ShouldBe(ResponseStatus.Success);
        }
        [Fact]
        public async Task GetSpectacularImagesListWithDetails_Selected_Valid()
        {
            var handler = new GetSpectacularImagesListWithDetailsRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new GetSpectacularImagesListWithDetailsRequest() { justSelected = true }, CancellationToken.None);

            result.Errors.ShouldBeNull();
            result.Tentities.Count.ShouldBe(4);
            result.Tentity.ShouldBeNull();
            result.Status.ShouldBe(ResponseStatus.Success);
        }
    }
}
