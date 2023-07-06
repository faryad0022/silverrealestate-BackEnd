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

namespace BackEnd_UnitTest.Facts.General.SpectacularImages.Queries
{
    public class GetSpectacularLocationImagesWithDetailsRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitOfWork;
        public GetSpectacularLocationImagesWithDetailsRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetSpectacularLocationImagesWithDetails_Valid()
        {
            var handler = new GetSpectacularLocationImagesWithDetailsRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new GetSpectacularLocationImagesWithDetailsRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);


            result.Errors.ShouldBeNull();
        }


        [Fact]
        public async Task GetSpectacularLocationImagesWithDetails_Notfound_InValid()
        {
            var handler = new GetSpectacularLocationImagesWithDetailsRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new GetSpectacularLocationImagesWithDetailsRequest() { Id = 11 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);


            result.Errors.ShouldBeNull();
        }
    }
}
