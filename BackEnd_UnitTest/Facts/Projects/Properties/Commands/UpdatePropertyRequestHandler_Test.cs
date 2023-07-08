using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.PropertyFeatures.Handler.Commands;
using Application.features.Projects.PropertyFeatures.Request.Commands;
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
    public class UpdatePropertyRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public UpdatePropertyRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task UpdatePropertyRequestHandler_Valid()
        {
            var handler = new UpdatePropertyRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdatePropertyRequest() { updatePropertyDTO = PropertyModelGenerator.updatePropertyDTO_Valid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task UpdatePropertyRequestHandler_Validation_PropertyType_NotExist_InValid()
        {
            var handler = new UpdatePropertyRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdatePropertyRequest() { updatePropertyDTO = PropertyModelGenerator.updatePropertyDTO_Validation_PropertyTypeId_InValid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();
        }
        [Fact]
        public async Task UpdatePropertyRequestHandler_Validation_NotFound_InValid()
        {
            var handler = new UpdatePropertyRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdatePropertyRequest() { updatePropertyDTO = PropertyModelGenerator.updatePropertyDTO_Validation_Notfound_InValid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();
        }
    }
}
