using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Domain.Entities.GeneralSiteInformation;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Mocks.Models.SpectacularLocations
{
    public static class SpectacularLocationModelGenerator
    {
        public static List<Spectacularlocation> spectacularLocationList = new()
        {
            new Spectacularlocation()
            {
                Id=1,
                IsSelected=true,
                Name="Ghost City"
            },
            new Spectacularlocation()
            {
                Id=2,
                IsSelected=true,
                Name="Wall City"
            },
            new Spectacularlocation()
            {
                Id=3,
                IsSelected=false,
                Name="Long Beach"
            },
            new Spectacularlocation()
            {
                Id=4,
                IsSelected=false,
                Name="Casino"
            }
        };
        public static CreateSpectacularLocationDTO CreateSpectacularLocationDTO_Valid = new()
        {
            Name = "Girne"
        };
        public static CreateSpectacularLocationDTO CreateSpectacularLocationDTO_ValidationError_InValid = new()
        {
            Name = ""
        };

        public static UpdateSpectacularLocationDTO UpdateSpectacularLocationDTO_Valid = new()
        {
            Id = 1,
            Name = "Faryad"
        };
        public static UpdateSpectacularLocationDTO UpdateSpectacularLocationDTO_ValidationError_InValid = new()
        {
            Id = 1,
            Name = ""
        };
        public static UpdateSpectacularLocationDTO UpdateSpectacularLocationDTO_NotFound_InValid = new()
        {
            Id = 10,
            Name = "Faryad"
        };
    }
}
