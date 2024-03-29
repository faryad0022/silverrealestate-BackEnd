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

namespace BackEnd_UnitTest.Facts.Projects.PropertyContractTypes.Commands
{
    public class DeletePropertyContractTypeRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public DeletePropertyContractTypeRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task DeletePropertyContractType_Valid()
        {
            var handler = new DeletePropertyContractTypeRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new DeletePropertyContractTypeRequest() { Id = 2 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);

            result.Errors.ShouldBeNull();


        }
        [Fact]
        public async Task DeletePropertyContractType_NotFound_InValid()
        {
            var handler = new DeletePropertyContractTypeRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new DeletePropertyContractTypeRequest() { Id = 7 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);

            result.Errors.ShouldBeNull();


        }
    }
}
