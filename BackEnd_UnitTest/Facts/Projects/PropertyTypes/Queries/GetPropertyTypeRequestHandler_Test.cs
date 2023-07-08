﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.PropertyTypeFeatures.Handler.Queries;
using Application.features.Projects.PropertyTypeFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.PropertyTypes.Queries
{
    public class GetPropertyTypeRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public GetPropertyTypeRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task GetPropertyType_Valid()
        {
            var handler = new GetPropertyTypeRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyTypeRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task GetPropertyType_NotFound_InValid()
        {
            var handler = new GetPropertyTypeRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyTypeRequest() { Id = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();


        }
    }
}