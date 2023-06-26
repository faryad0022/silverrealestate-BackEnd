using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.ConstructorInformations.Handler.Commands;
using Application.features.GeneralInformations.ConstructorInformations.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.ConstructorInformations;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.ConstructorInformations.Commands
{
    public class CreateConstructorInformationRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public CreateConstructorInformationRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task CreateConstructorInformation_Valid()
        {
            var handler = new CreateConstructorInformationRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateConstructorInformationRequest() { createConstructorInformationDTO = ConstructorInformationModelGenerator.createConstructorInformationDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            
            result.Errors.ShouldBeNull();
            

        }
        [Fact]
        public async Task CreateConstructorInformation_Validation_InValid()
        {
            var handler = new CreateConstructorInformationRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateConstructorInformationRequest() { createConstructorInformationDTO = ConstructorInformationModelGenerator.createConstructorInformationDTO_Validation_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            
            result.Errors.ShouldNotBeNull();
            

        }
    }
}
