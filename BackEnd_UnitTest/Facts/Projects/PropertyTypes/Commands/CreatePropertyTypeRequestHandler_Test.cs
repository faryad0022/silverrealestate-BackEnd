using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.PropertyTypeFeatures.Handler.Commands;
using Application.features.Projects.PropertyTypeFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.Projects.PropertyTypeData;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.PropertyTypes.Commands
{
    public class CreatePropertyTypeRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public CreatePropertyTypeRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task CreatePropertyType_Valid()
        {
            var handler = new CreatePropertyTypeRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreatePropertyTypeRequest() { createPropertyTypeDTO = PropertyTypeModelGenerator.createPropertyTypeDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task CreatePropertyType_Validation_InValid()
        {
            var handler = new CreatePropertyTypeRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreatePropertyTypeRequest() { createPropertyTypeDTO = PropertyTypeModelGenerator.createPropertyTypeDTO_Validation_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();
        }
    }
}
