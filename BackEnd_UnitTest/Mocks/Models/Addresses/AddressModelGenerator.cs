using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Domain.Entities.GeneralSiteInformation;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Mocks.Models.Addresses
{
    public static class AddressModelGenerator
    {
        public static List<Address> AddressList = new()
         {
             new Address
             {
                 Id=1,
                 CellPhone="09123071411",
                 Email="Mahancomputer49@gmail.com",
                 Telephone="02122122391",
                 Location="Tehran",
                 IsSelected=true

             },
             new Address
             {
                 Id=2,
                 CellPhone="00905338355243",
                 Email="Mahancomputer@hotmail.com",
                 Telephone="02122122391",
                 Location="Cyprus"

             }
         };
        public static CreateAddressDTO AddressDTO = new CreateAddressDTO
        {
            CellPhone = "09125757063",
            Email = "faryad@gmail.com",
            Telephone = "22480713",
            Location = "Tehran"

        };
        public static CreateAddressDTO AddressDTO_Invalid_Email = new CreateAddressDTO
        {
            CellPhone = "09125757063",
            Email = "faryadgmail.com",
            Telephone = "22480713",
            Location = "Tehran"

        };

        public static UpdateAddressDTO updateAddressDTO_Valid = new UpdateAddressDTO
        {
            Id = 1,
            CellPhone = "09352499091",
            Email = "Mahancomputer49@gmail.com",
            Telephone = "02122122391",
            Location = "Tehran"

        };
        public static UpdateAddressDTO updateAddressDTO_InValid = new UpdateAddressDTO
        {
            Id = 1,
            CellPhone = "09352499091",
            Email = "Mahancomputer49gmail.com",
            Telephone = "02122122391",
            Location = "Tehran"

        };

        public static UpdateAddressDTO updateAddressDTO_NotFound_InValid = new UpdateAddressDTO
        {
            Id = 5,
            CellPhone = "09352499091",
            Email = "Mahancomputer49gmail.com",
            Telephone = "02122122391",
            Location = "Tehran"

        };



    }
}
