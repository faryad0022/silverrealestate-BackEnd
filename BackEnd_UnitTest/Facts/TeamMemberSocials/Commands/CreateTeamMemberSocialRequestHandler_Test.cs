using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials;
using Application.features.GeneralInformations.TeamMemberSocialFeatures.Handler.Commands;
using Application.features.GeneralInformations.TeamMemberSocialFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.TeamMemberSocials.Commands
{
    public class CreateTeamMemberSocialRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitOfWork;
        public CreateTeamMemberSocialRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetTeamMemberSocialListWithDetails_Valid()
        {
            var handler = new CreateTeamMemberSocialRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new CreateTeamMemberSocialRequest() { createTeamMemberSocialDTO = TeamMemberSocialModelGenerator.CreateTeamMemberSocialDTO_Valid }, CancellationToken.None);

            result.Tentity.ShouldBeOfType(typeof(TeamMemberSocialDTO));
            result.Tentities.ShouldBeNull();
            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentity.ShouldNotBeNull();
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task GetTeamMemberSocialListWithDetails_ValidationError_InValid()
        {
            var handler = new CreateTeamMemberSocialRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new CreateTeamMemberSocialRequest() { createTeamMemberSocialDTO = TeamMemberSocialModelGenerator.CreateTeamMemberSocialDTO_ValidationError_InValid }, CancellationToken.None);

            result.Tentities.ShouldBeNull();
            result.Tentity.ShouldBeNull();
            result.Status.ShouldBe(ResponseStatus.ValidationError);
            result.Errors.ShouldNotBeNull();
        }
    }
}
