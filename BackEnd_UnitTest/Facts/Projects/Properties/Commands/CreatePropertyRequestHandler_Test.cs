using Application.Const.Response;
using Application.Contract.Persistence;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.Projects.Properties;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.Properties.Commands
{
    public class CreatePropertyRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public CreatePropertyRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task CreateProperty_Valid()
        {
            var handler = new CreatePropertyRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreatePropertyRequest() { createPropertyDTO = PropertyModelGenerator.createPropertyDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task CreateProperty_Validation_CityId_InValid()
        {
            var handler = new CreatePropertyRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreatePropertyRequest() { createPropertyDTO = PropertyModelGenerator.createPropertyDTO_Validation_CityId_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();
        }
        [Fact]
        public async Task CreateProperty_Validation_FeatureImage_InValid()
        {
            var handler = new CreatePropertyRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreatePropertyRequest() { createPropertyDTO = PropertyModelGenerator.createPropertyDTO_Validation_FeatureImage_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();
        }
    }
}
