using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Domain.Entities.GeneralSiteInformation;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Mocks.Models.SoectacularImages
{
    public static class SpectacularLocationImageModelGenerator
    {
        public static List<SpectacularLocationImages> SpectacularLocationImagesList = new()
        {
            new SpectacularLocationImages
            {
                Id = 1,
                Image="GhostCity.jpg",
                SpectacularlocationId= 1,
                Text="Open Recently",
                IsSelected=true,
                IsDelete=false
            },
            new SpectacularLocationImages
            {
                Id =2 ,
                Image="GhostCity2.jpg",
                SpectacularlocationId= 1,
                Text="Open Recently",
                IsSelected=true,
                IsDelete=false
            },
            new SpectacularLocationImages
            {
                Id = 3,
                Image="GhostCity3.jpg",
                SpectacularlocationId= 1,
                Text="Open Recently",
                IsSelected=true,
                IsDelete=false
            },
            new SpectacularLocationImages
            {
                Id = 4,
                Image="WallCity1.jpg",
                SpectacularlocationId= 1,
                Text="Open Recently",
                IsSelected=false,
                IsDelete=false
            },
            new SpectacularLocationImages
            {
                Id = 5,
                Image="WallCity2.jpg",
                SpectacularlocationId= 1,
                Text="Open Recently",
                IsSelected=true,
                IsDelete=false
            },
        };


        public static CreateSpectacularLocationImagesDTO createSpectacularImagesDTO_Valid = new CreateSpectacularLocationImagesDTO
        {
            Text = "Wall Cilty since 1799BC",
            SpectacularlocationId = 2,
            Image = "WallCity.jpg",
            Description = "Wall Cilty since 1799BC"
        };
        public static CreateSpectacularLocationImagesDTO createSpectacularImagesDTO_ValidationError_InValid = new CreateSpectacularLocationImagesDTO
        {
            Text = "",
            Image = "WallCity.jpg",
            Description = "Wall Cilty since 1799BC"
        };
        public static CreateSpectacularLocationImagesDTO createSpectacularImagesDTO_ValidationError_ParentId_InValid = new CreateSpectacularLocationImagesDTO
        {
            SpectacularlocationId = 0,
            Text = "Wall Cilty since 1799BC",
            Image = "WallCity.jpg",
            Description = "Wall Cilty since 1799BC"
        };

        public static UpdateSpectacularLocationImagesDTO updateSpectacularImags_Valid = new UpdateSpectacularLocationImagesDTO()
        {
            Id = 1,
            Image = "GhostCity11.jpg",
            SpectacularlocationId = 1,
            Text = "Open Recently Updated",
            Description = "Open Recently Updated"
        };
        public static UpdateSpectacularLocationImagesDTO updateSpectacularImags_NotFound_InValid = new UpdateSpectacularLocationImagesDTO()
        {
            Id = 11,
            Image = "GhostCity11.jpg",
            SpectacularlocationId = 1,
            Text = "Open Recently Updated",
        };
        public static UpdateSpectacularLocationImagesDTO updateSpectacularImags_MustSelected_ValidationError_InValid = new UpdateSpectacularLocationImagesDTO()
        {
            Id = 1,
            Image = "GhostCity11.jpg",
            Text = "Open Recently Updated",
            Description = "Open Recently Updated"
        };
        public static UpdateSpectacularLocationImagesDTO updateSpectacularImags_ValidationError_InValid = new UpdateSpectacularLocationImagesDTO()
        {
            Id = 1,
            Image = "",
            SpectacularlocationId = 1,
            Text = "Open Recently Updated",
        };

    }
}
