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

namespace BackEnd_UnitTest.Facts.Projects.PropertyPlans.Queries
{
    public class GetPropertyPlanListRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public GetPropertyPlanListRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task GetPropertyPlan_Valid()
        {
            var handler = new GetPropertyPlanListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyPlanListRequest() { PropertyId = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task GetPropertyPlanList_NotFound_InValid()
        {
            var handler = new GetPropertyPlanListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyPlanListRequest() { PropertyId = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NoContent);
            result.Errors.ShouldBeNull();


        }
    }
}
