using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.features.GeneralInformations.SpectacularLocationFeatures.Handler.Commands;
using Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.SpectacularLocations.Commands
{
    public class ChnageSpectacularLocationSelectedStatusRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitOfWorf;
        public ChnageSpectacularLocationSelectedStatusRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitOfWorf = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task ChnageSpectacularLocationSelectedStatus_valid()
        {
            var handler = new ChnageSpectacularLocationSelectedStatusRequestHandler(_mapper, _unitOfWorf.Object);
            var result = await handler.Handle(new ChnageSpectacularLocationSelectedStatusRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            
            

        }
        [Fact]
        public async Task ChnageSpectacularLocationSelectedStatus_NotFound_Invalid()
        {
            var handler = new ChnageSpectacularLocationSelectedStatusRequestHandler(_mapper, _unitOfWorf.Object);
            var result = await handler.Handle(new ChnageSpectacularLocationSelectedStatusRequest() { Id = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            
            

        }
    }
}
