using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.FacilityFeatures.Handler.Commands;
using Application.features.Projects.FacilityFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.Projects.Facilities;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.Facilities.Commands
{
    public class CreateFacilityRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public CreateFacilityRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task CreateFacility_Valid()
        {
            var handler = new CreateFacilityRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateFacilityRequest() { createFacilityDTO = FacilityModelGenerator.createFacilityDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);

            result.Errors.ShouldBeNull();


        }
        [Fact]
        public async Task CreateFacility_Validation_InValid()
        {
            var handler = new CreateFacilityRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateFacilityRequest() { createFacilityDTO = FacilityModelGenerator.createFacilityDTO_Validation_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);

            result.Errors.ShouldNotBeNull();


        }
    }
}
