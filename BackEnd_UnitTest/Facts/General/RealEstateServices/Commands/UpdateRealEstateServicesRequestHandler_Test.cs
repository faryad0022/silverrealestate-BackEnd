using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Handler.Commands;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.RealEstateService;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.General.RealEstateServices.Commands
{
    public class UpdateRealEstateServicesRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public UpdateRealEstateServicesRequestHandler_Test()
        {
            var mapConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task UpdateRealEstateServices_Valid()
        {
            var handler = new UpdateRealEstateServicesRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateRealEstateServicesRequest() { updateRealEstateServicesDTO = RealEstateServicesModelGenerator.updateRealEstateServicesDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);


        }
        [Fact]
        public async Task UpdateRealEstateServices_Validation_InValid()
        {
            var handler = new UpdateRealEstateServicesRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateRealEstateServicesRequest() { updateRealEstateServicesDTO = RealEstateServicesModelGenerator.updateRealEstateServicesDTO_InValid_ValidationError }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();


        }

        [Fact]
        public async Task UpdateRealEstateServices_NotFound_InValid()
        {
            var handler = new UpdateRealEstateServicesRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateRealEstateServicesRequest() { updateRealEstateServicesDTO = RealEstateServicesModelGenerator.updateRealEstateServicesDTO_InValid_NotFound }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();


        }
    }
}
