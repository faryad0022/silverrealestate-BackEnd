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
    public class UpdateTeamMemberSocialRequestHandler_Teast
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitOfWork;
        public UpdateTeamMemberSocialRequestHandler_Teast()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task UpdateTeamMemberSocial_Valid()
        {
            var handler = new UpdateTeamMemberSocialRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new UpdateTeamMemberSocialRequest() { updateTeamMemberSocialDTO = TeamMemberSocialModelGenerator.UpdateTeamMemberSocialDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentity.ShouldNotBeNull();
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldBeNull();
            result.Tentity.Icon.ShouldBe("fab fa-instagram");
            result.Tentity.ShouldBeOfType(typeof(TeamMemberSocialDTO));
        }
        [Fact]
        public async Task UpdateTeamMemberSocial_ValidationError_InValid()
        {
            var handler = new UpdateTeamMemberSocialRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new UpdateTeamMemberSocialRequest() { updateTeamMemberSocialDTO = TeamMemberSocialModelGenerator.UpdateTeamMemberSocialDTO_ValidationError_InValid }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.ValidationError);
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldNotBeNull();
            result.Tentities.ShouldBeNull();
        }
        [Fact]
        public async Task UpdateTeamMemberSocial_MustSelected_ValidationError_InValid()
        {
            var handler = new UpdateTeamMemberSocialRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new UpdateTeamMemberSocialRequest() { updateTeamMemberSocialDTO = TeamMemberSocialModelGenerator.UpdateTeamMemberSocialDTO_ValidationError_MustSelectParent_InValid }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.ValidationError);
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldNotBeNull();
            result.Tentities.ShouldBeNull();
        }
        [Fact]
        public async Task UpdateTeamMemberSocial_Notfound_InValid()
        {
            var handler = new UpdateTeamMemberSocialRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new UpdateTeamMemberSocialRequest() { updateTeamMemberSocialDTO = TeamMemberSocialModelGenerator.UpdateTeamMemberSocialDTO_NotFound_InValid }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.NotFound);
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldBeNull();
        }
    }
}
