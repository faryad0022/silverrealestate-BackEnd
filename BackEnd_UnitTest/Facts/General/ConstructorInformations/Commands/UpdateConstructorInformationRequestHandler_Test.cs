using Application.Const.Response;
using Application.Contract.Persistence;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.General.ConstructorInformations;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.General.ConstructorInformations.Commands
{
    public class UpdateConstructorInformationRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public UpdateConstructorInformationRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task UpdateConstructorInformationRequestHandler_Valid()
        {
            var handler = new UpdateConstructorInformationRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateConstructorInformationRequest() { updateConstructorInformationDTO = ConstructorInformationsModelGenerator.updateConstructorInformationDTO_Valid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.Success);

            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task UpdateConstructorInformationRequestHandler_Validation_InValid()
        {
            var handler = new UpdateConstructorInformationRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateConstructorInformationRequest() { updateConstructorInformationDTO = ConstructorInformationsModelGenerator.updateConstructorInformationDTO_Validation_InValid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.ValidationError);

            result.Errors.ShouldNotBeNull();
        }
        [Fact]
        public async Task UpdateConstructorInformationRequestHandler_NotFound_InValid()
        {
            var handler = new UpdateConstructorInformationRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateConstructorInformationRequest() { updateConstructorInformationDTO = ConstructorInformationsModelGenerator.updateConstructorInformationDTO_Notfound_InValid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.NotFound);

            result.Errors.ShouldBeNull();
        }

    }

}
