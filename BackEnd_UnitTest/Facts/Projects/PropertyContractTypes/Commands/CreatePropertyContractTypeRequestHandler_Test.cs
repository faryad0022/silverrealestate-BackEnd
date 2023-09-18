using Application.Const.Response;
using Application.Contract.Persistence;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.Projects.PropertyContractTypeData;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.PropertyContractTypes.Commands
{
    public class CreatePropertyContractTypeRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public CreatePropertyContractTypeRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task CreatePropertyContractType_Valid()
        {
            var handler = new CreatePropertyContractTypeRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreatePropertyContractTypeRequest() { createPropertyContractTypeDTO = PropertyContractTypeModelGenerator.createPropertyContractTypeDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task CreatePropertyContractType_Validation_InValid()
        {
            var handler = new CreatePropertyContractTypeRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreatePropertyContractTypeRequest() { createPropertyContractTypeDTO = PropertyContractTypeModelGenerator.createPropertyContractTypeDTO_Validation_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();
        }
    }
}
