using Application.Const.Response;
using Application.Contract.Persistence;
using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using Application.features.GeneralInformations.SocialFeatures.Handler.Commands;
using Application.features.GeneralInformations.SocialFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.Socials;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Socials.Commands
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
        public async Task UpdateSocial_Valid()
        {
            var handler = new UpdateSocialRequestHandler(_mock.Object, _mapper);
            var result = await handler.Handle(new UpdateSocialRequest() 
            { 
                UpdateSocialDTO=SocialModelGenerator._updateSocialDTO_Valid
            },CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
        }
    }
}
