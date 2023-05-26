using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials;
using Application.features.GeneralInformations.TeamMemberSocialFeatures.Handler.Queries;
using Application.features.GeneralInformations.TeamMemberSocialFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.TeamMemberSocials.Queries
{
    public class GetTeamMemberSocialWithDetailsRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitOfWork;
        public GetTeamMemberSocialWithDetailsRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetTeamMemberSocialWithDetails_Valid()
        {
            var handler = new GetTeamMemberSocialWithDetailsRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new GetTeamMemberSocialWithDetailsRequest() { Id = 1 }, CancellationToken.None);

            result.Tentity.ShouldBeOfType(typeof(TeamMemberSocialDTO));
            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentities.ShouldBeNull();
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task GetTeamMemberSocialWithDetails_NotFound_InValid()
        {
            var handler = new GetTeamMemberSocialWithDetailsRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new GetTeamMemberSocialWithDetailsRequest() { Id = 11 }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.NotFound);

            result.Tentities.ShouldBeNull();
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldBeNull();
        }
    }
}
