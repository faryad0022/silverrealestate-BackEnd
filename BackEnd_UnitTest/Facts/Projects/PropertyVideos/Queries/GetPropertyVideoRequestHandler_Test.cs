﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.PropertyVideos.Queries
{
    public class GetPropertyVideoRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public GetPropertyVideoRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task GetPropertyVideo_Valid()
        {
            var handler = new GetPropertyVideoRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyVideoRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task GetPropertyVideo_NotFound_InValid()
        {
            var handler = new GetPropertyVideoRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyVideoRequest() { Id = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();


        }
    }
}
