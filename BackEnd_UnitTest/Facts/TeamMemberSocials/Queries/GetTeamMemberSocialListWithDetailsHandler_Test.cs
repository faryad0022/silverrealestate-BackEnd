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
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.TeamMemberSocials.Queries
{
    public class GetTeamMemberSocialListWithDetailsHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitOfWork;
        public GetTeamMemberSocialListWithDetailsHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetTeamMemberSocialListWithDetails_SelectedStatus_Valid()
        {
            var handler = new GetTeamMemberSocialListWithDetailsHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new GetTeamMemberSocialListWithDetails() { justSelected = true }, CancellationToken.None);

            result.Tentities.ShouldBeOfType(typeof(List<TeamMemberSocialDTO>));
            result.Tentities.Count.ShouldBe(2);
            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task GetTeamMemberSocialListWithDetails_Valid()
        {
            var handler = new GetTeamMemberSocialListWithDetailsHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new GetTeamMemberSocialListWithDetails() { justSelected = false }, CancellationToken.None);

            result.Tentities.ShouldBeOfType(typeof(List<TeamMemberSocialDTO>));
            result.Tentities.Count.ShouldBe(3);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldBeNull();
        }

    }
}
