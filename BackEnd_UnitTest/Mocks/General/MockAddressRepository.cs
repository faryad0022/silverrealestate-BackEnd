using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using BackEnd_UnitTest.Models.General.Addresses;
using Domain.Entities.GeneralSiteInformation;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.General
{
    public static class MockAddressRepository
    {
        public static Mock<IAddressRepository> GetAddressRepository()
        {
            var _mock = new Mock<IAddressRepository>();

            _mock.Setup(m => m.GetEntityAsync(It.IsAny<long>()))
                .ReturnsAsync((long id) => AddressModelGenerator.AddressList.FirstOrDefault(x => x.Id == id));
            _mock.Setup(m => m.GetAllAsync())
                .ReturnsAsync(AddressModelGenerator.AddressList.Where(t => !t.IsDelete).ToList());
            _mock.Setup(m => m.AddEntityAsync(It.IsAny<Address>()))
                .ReturnsAsync((Address address) =>
                            {
                                AddressModelGenerator.AddressList.Add(address);
                                return address;
                            });
            _mock.Setup(m => m.UpdateEntity(It.IsAny<Address>())).Callback(() => { return; });
            return _mock;
        }
    }
}
