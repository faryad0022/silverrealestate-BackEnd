﻿namespace Application.DTOs.GeneralSiteInformationsDTO.Address
{
    public class CreateAddressDTO : IAddressDTO
    {
        public string Location { get; set; }
        public string CellPhone { get; set; }
        public string Telephone { get; set; }
        public string WorkHour { get; set; }
        public string Email { get; set; }
    }
}
