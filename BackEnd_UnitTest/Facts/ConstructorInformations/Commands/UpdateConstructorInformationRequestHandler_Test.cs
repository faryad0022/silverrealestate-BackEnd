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
            var result = await handler.Handle(new UpdateConstructorInformationRequest() { updateConstructorInformationDTO = ConstructorInformationModelGenerator.updateConstructorInformationDTO_Valid }, CancellationToken.None);

            result.Tentity.ShouldNotBeNull();
            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentities.ShouldBeNull();
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task UpdateConstructorInformationRequestHandler_Validation_InValid()
        {
            var handler = new UpdateConstructorInformationRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateConstructorInformationRequest() { updateConstructorInformationDTO = ConstructorInformationModelGenerator.updateConstructorInformationDTO_Validation_InValid }, CancellationToken.None);

            result.Tentity.ShouldBeNull();
            result.Status.ShouldBe(ResponseStatus.ValidationError);
            result.Tentities.ShouldBeNull();
            result.Errors.ShouldNotBeNull();
        }
        [Fact]
        public async Task UpdateConstructorInformationRequestHandler_NotFound_InValid()
        {
            var handler = new UpdateConstructorInformationRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateConstructorInformationRequest() { updateConstructorInformationDTO = ConstructorInformationModelGenerator.updateConstructorInformationDTO_Notfound_InValid }, CancellationToken.None);

            result.Tentity.ShouldNotBeNull();
            result.Status.ShouldBe(ResponseStatus.NotFound);
            result.Tentities.ShouldBeNull();
            result.Errors.ShouldBeNull();
        }

    }

}
