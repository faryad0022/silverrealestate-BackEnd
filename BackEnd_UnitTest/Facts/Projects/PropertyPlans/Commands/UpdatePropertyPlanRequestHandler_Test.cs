using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.PropertyPlanFeatures.Handler.Commands;
using Application.features.Projects.PropertyPlanFeatures.Request.Commands;
using Application.features.Projects.PropertyVideFeatures.Handler.Commands;
using Application.features.Projects.PropertyVideFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
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
    public class UpdatePropertyPlanRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public UpdatePropertyPlanRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task UpdatePropertyPlanRequestHandler_Valid()
        {
            var handler = new UpdatePropertyPlanRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdatePropertyPlanRequest() { updatePropertyPlanDTO = PropertyPlanModelGenerator._updatePropertyPlanDTO_Valid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }

        [Fact]
        public async Task UpdatePropertyPlanRequestHandler_Validation_NotFound_InValid()
        {
            var handler = new UpdatePropertyPlanRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdatePropertyPlanRequest() { updatePropertyPlanDTO = PropertyPlanModelGenerator._updatePropertyPlanDTO_ValidationError_PropertyNotFound_InValid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();
        }
        [Fact]
        public async Task UpdatePropertyPlanRequestHandler_Validation_Plan_NotFound_InValid()
        {
            var handler = new UpdatePropertyPlanRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdatePropertyPlanRequest() { updatePropertyPlanDTO = PropertyPlanModelGenerator._updatePropertyPlanDTO_ValidationError_PropertyPlanNotFound_InValid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();
        }
    }
}
