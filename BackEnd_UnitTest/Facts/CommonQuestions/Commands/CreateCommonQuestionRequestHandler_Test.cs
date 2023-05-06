using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.CommonQuestionFeatures.Handler.Commands;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.CommonQuestions;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.CommonQuestions.Commands
{
    public class CreateCommonQuestionRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public CreateCommonQuestionRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task CreateCommonQuestion_Valid()
        {
            var handler = new CreateCommonQuestionRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateCommonQuestionRequest() { createCommonQuestionDTO = CommonQuestionModelGenerator.createCommonQuestionDTO }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentity.ShouldNotBeNull();
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldBeNull();

        }
        [Fact]
        public async Task CreateCommonQuestion_Validation_InValid()
        {
            var handler = new CreateCommonQuestionRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateCommonQuestionRequest() { createCommonQuestionDTO = CommonQuestionModelGenerator.createCommonQuestionDTO_Invalid }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.ValidationError);
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldNotBeNull();
            result.Tentities.ShouldBeNull();

        }
    }
}
