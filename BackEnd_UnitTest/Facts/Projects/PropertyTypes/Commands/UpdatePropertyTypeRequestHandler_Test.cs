using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.PropertyTypeFeatures.Handler.Commands;
using Application.features.Projects.PropertyTypeFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.Projects.PropertyTypeData;
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
    public class UpdatePropertyTypeRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public UpdatePropertyTypeRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task UpdatePropertyTypeRequestHandler_Valid()
        {
            var handler = new UpdatePropertyTypeRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdatePropertyTypeRequest() { updatePropertyTypeDTO = PropertyTypeModelGenerator.updatePropertyTypeDTO_Valid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task UpdatePropertyTypeRequestHandler_Validation_InValid()
        {
            var handler = new UpdatePropertyTypeRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdatePropertyTypeRequest() { updatePropertyTypeDTO = PropertyTypeModelGenerator.updatePropertyTypeDTO_Validation_InValid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();
        }
        [Fact]
        public async Task UpdatePropertyTypeRequestHandler_Validation_NotFound_InValid()
        {
            var handler = new UpdatePropertyTypeRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdatePropertyTypeRequest() { updatePropertyTypeDTO = PropertyTypeModelGenerator.updatePropertyTypeDTO_Validation_Notfound_InValid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();
        }
    }
}
