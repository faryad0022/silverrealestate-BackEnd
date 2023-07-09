using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.FacilityFeatures.Handler.Queries;
using Application.features.Projects.FacilityFeatures.Request.Queries;
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

namespace BackEnd_UnitTest.Facts.Projects.Facilities.Queries
{
    public class GetFacilityRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public GetFacilityRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task GetFacility_Valid()
        {
            var handler = new GetFacilityRequestHandler(_mapper,_mock.Object );
            var result = await handler.Handle(new GetFacilityRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task GetFacility_NotFound_InValid()
        {
            var handler = new GetFacilityRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetFacilityRequest() { Id = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();


        }
    }
}
