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

namespace BackEnd_UnitTest.Facts.RealEstateServices.Commands
{
    public class CreateRealEstateServicesRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public CreateRealEstateServicesRequestHandler_Test()
        {
            var mapConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task CreateRealEstateService_Valid()
        {
            var handler = new CreateRealEstateServicesRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateRealEstateServicesRequest() { createRealEstateServicesDTO = RealEstateServicesModelGenerator.createRealEstateServicesDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            
            
            result.Errors.ShouldBeNull();

        }
        [Fact]
        public async Task CreateRealEstateService_InValid_NameRequired()
        {
            var handler = new CreateRealEstateServicesRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateRealEstateServicesRequest() { createRealEstateServicesDTO = RealEstateServicesModelGenerator.createRealEstateServicesDTO_InValid_NameRequired }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            
            
            result.Errors.ShouldNotBeNull();
            result.Errors.Count.ShouldBe(2);
        }
    }
}
