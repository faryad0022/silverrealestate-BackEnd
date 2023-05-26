using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials;
using Application.features.GeneralInformations.TeamMemberSocialFeatures.Handler.Commands;
using Application.features.GeneralInformations.TeamMemberSocialFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.TeamMemberSocials.Commands
{
    public class ChangeTeamMemberSocialSelectedStatusRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitOfWork;
        public ChangeTeamMemberSocialSelectedStatusRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task ChangeTeamMemberSocialSelectedStatus_Valid()
        {
            var handler = new ChangeTeamMemberSocialSelectedStatusRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new ChangeTeamMemberSocialSelectedStatusRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentity.ShouldNotBeNull();
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldBeNull();
            result.Tentity.ShouldBeOfType(typeof(TeamMemberSocialDTO));
        }
        [Fact]
        public async Task ChangeTeamMemberSocialSelectedStatus_Valid_Notfound_InValid()
        {
            var handler = new ChangeTeamMemberSocialSelectedStatusRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new ChangeTeamMemberSocialSelectedStatusRequest() { Id = 11 }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.NotFound);
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldBeNull();
        }
    }
}
