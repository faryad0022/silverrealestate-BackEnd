using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.features.GeneralInformations.TeamMemberFeatures.Hnadler.Queries;
using Application.features.GeneralInformations.TeamMemberFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.TeamMembers.Queries
{
    public class GetTeamMemberRequestHandler_Teast
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitOfWork;
        public GetTeamMemberRequestHandler_Teast()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetTeamMember_Valid()
        {
            var handler = new GetTeamMemberRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new GetTeamMemberRequest { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentities.ShouldBeNull();
            result.Errors.ShouldBeNull();
            result.Tentity.Name.ShouldBe("Faryad");
            result.Tentity.ShouldBeOfType(typeof(TeamMemberDTO));
        }
        [Fact]
        public async Task GetTeamMember_Notfound_InValid()
        {
            var handler = new GetTeamMemberRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new GetTeamMemberRequest { Id = 10 }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.NotFound);
            result.Tentities.ShouldBeNull();
            result.Errors.ShouldBeNull();
            result.Tentity.ShouldBeNull();
        }
    }
}
