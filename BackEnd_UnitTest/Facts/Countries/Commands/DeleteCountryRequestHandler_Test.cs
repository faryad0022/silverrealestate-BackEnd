using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.CountryFeatures.Handler.Commands;
using Application.features.Projects.CountryFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Countries.Commands
{
    public class DeleteCountryRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public DeleteCountryRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task DeleteCountry_Valid()
        {
            var handler = new DeleteCountryRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new DeleteCountryRequest() { Id = 2 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);

            result.Errors.ShouldBeNull();


        }
        [Fact]
        public async Task DeleteCountry_NotFound_InValid()
        {
            var handler = new DeleteCountryRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new DeleteCountryRequest() { Id = 7 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);

            result.Errors.ShouldBeNull();


        }
    }
}
