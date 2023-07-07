using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.PropertyContractTypeFeatures.Handler.Queries;
using Application.features.Projects.PropertyContractTypeFeatures.Request.Queries;
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

namespace BackEnd_UnitTest.Facts.Projects.PropertyContractTypes.Queries
{
    public class GetPropertyContractTypeRequestHandler_Tets
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public GetPropertyContractTypeRequestHandler_Tets()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task GetPropertyContractType_Valid()
        {
            var handler = new GetPropertyContractTypeRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyContractTypeRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task GetPropertyContractType_NotFound_InValid()
        {
            var handler = new GetPropertyContractTypeRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyContractTypeRequest() { Id = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();


        }
    }
}
