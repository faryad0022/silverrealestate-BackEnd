using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.PropertyTypeFeatures.Handler.Commands;
using Application.features.Projects.PropertyTypeFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.PropertyTypes.Commands
{
    public class DeletePropertyTypeRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public DeletePropertyTypeRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task DeletePropertyType_Valid()
        {
            var handler = new DeletePropertyTypeRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new DeletePropertyTypeRequest() { Id = 2 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);

            result.Errors.ShouldBeNull();


        }
        [Fact]
        public async Task DeletePropertyType_NotFound_InValid()
        {
            var handler = new DeletePropertyTypeRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new DeletePropertyTypeRequest() { Id = 7 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);

            result.Errors.ShouldBeNull();


        }
    }
}
