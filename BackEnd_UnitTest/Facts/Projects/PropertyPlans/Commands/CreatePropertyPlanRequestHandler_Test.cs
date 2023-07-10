using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.PropertyPlanFeatures.Handler.Commands;
using Application.features.Projects.PropertyPlanFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.Projects.PropertyGalleries;
using BackEnd_UnitTest.Models.Projects.PropertyPlans;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.PropertyPlans.Commands
{
    public class CreatePropertyPlanRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public CreatePropertyPlanRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task CreatePropertyPlan_valid()
        {
            var handler = new CreatePropertyPlanRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreatePropertyPlanRequest() { createPropertyPlanDTO = PropertyPlanModelGenerator._createPropertyPlanDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();

        }
        [Fact]
        public async Task CreatePropertyPlan_ValidationError_Invalid()
        {
            var handler = new CreatePropertyPlanRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreatePropertyPlanRequest() { createPropertyPlanDTO = PropertyPlanModelGenerator._createPropertyPlanDTO_ValidationError_Invalid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();

        }
        [Fact]
        public async Task CreatePropertyPlan_ValidationError_NotExist_Invalid()
        {
            var handler = new CreatePropertyPlanRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreatePropertyPlanRequest() { createPropertyPlanDTO = PropertyPlanModelGenerator._createPropertyPlanDTO_ValidationError_NotExist_Invalid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();

        }
    }
}
