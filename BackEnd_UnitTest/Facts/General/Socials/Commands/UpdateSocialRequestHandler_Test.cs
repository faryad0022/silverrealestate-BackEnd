using Application.Const.Response;
using Application.Contract.Persistence;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.General.Socials;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.General.Socials.Commands
{
    public class UpdateSocialRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public UpdateSocialRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task UpdateSocial_ValidationError_InValid()
        {
            var handler = new UpdateSocialRequestHandler(_mock.Object, _mapper);
            var result = await handler.Handle(new UpdateSocialRequest()
            {
                UpdateSocialDTO = SocialModelGenerator._updateSocialDTO_ValidationError_InValid
            }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();

        }
        [Fact]
        public async Task UpdateSocial_NotFound_InValid()
        {
            var handler = new UpdateSocialRequestHandler(_mock.Object, _mapper);
            var result = await handler.Handle(new UpdateSocialRequest()
            {
                UpdateSocialDTO = SocialModelGenerator._updateSocialDTO_NotFound_InValid
            }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);


            result.Errors.ShouldBeNull();

        }
        [Fact]
        public async Task UpdateSocial_Valid()
        {
            var handler = new UpdateSocialRequestHandler(_mock.Object, _mapper);
            var result = await handler.Handle(new UpdateSocialRequest()
            {
                UpdateSocialDTO = SocialModelGenerator._updateSocialDTO_Valid
            }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
        }
    }
}
