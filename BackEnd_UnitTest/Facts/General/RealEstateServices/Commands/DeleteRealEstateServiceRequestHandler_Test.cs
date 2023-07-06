using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Handler.Commands;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.General.RealEstateServices.Commands
{
    public class DeleteRealEstateServiceRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public DeleteRealEstateServiceRequestHandler_Test()
        {
            var mapConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task DeleteRealEstateService_Valid()
        {
            var handler = new DeleteRealEstateServiceRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new DeleteRealEstateServiceRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);


        }

        [Fact]
        public async Task DeleteRealEstateService_NotFound_InValid()
        {
            var handler = new DeleteRealEstateServiceRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new DeleteRealEstateServiceRequest() { Id = 5 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);


        }
    }
}
