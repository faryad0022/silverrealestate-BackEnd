﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.CommonQuestionFeatures.Handler.Queries;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.CommonQuestions.Queries
{
    public class GetCommonQuestionRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetCommonQuestionRequestHandler_Test()
        {
            _mock = MockUniOfWork.GetMockUnitOfWork();
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
        }
        [Fact]
        public async Task GetCommonQuestion_Valid()
        {
            var handler = new GetCommonQuestionRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetCommonQuestionRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentity.ShouldNotBeNull();
            result.Tentities.ShouldBeNull();
            result.Errors.ShouldBeNull();
        }

        [Fact]
        public async Task GetCommonQuestion_NotFound_InValid()
        {
            var handler = new GetCommonQuestionRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetCommonQuestionRequest() { Id = 10 }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.NotFound);
            result.Tentity.ShouldBeNull();
            result.Tentities.ShouldBeNull();
            result.Errors.ShouldBeNull();
        }
    }
}
