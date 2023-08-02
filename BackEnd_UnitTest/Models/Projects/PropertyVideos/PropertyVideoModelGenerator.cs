using Application.DTOs.Project.PropertyVideos;
using Domain.Entities.Project;
using System;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Models.Projects.PropertyVideos
{
    public static class PropertyVideoModelGenerator
    {
        public static List<PropertyVideo> propertyVideolList = new()
        {
                new PropertyVideo
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = true,
                    PropertyId = 1,
                    VideoLink = "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/YHdtfcE0w0U\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe>"
                },
                new PropertyVideo
                {
                    Id = 2,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = true,
                    PropertyId = 2,
                    VideoLink = "<style>.h_iframe-aparat_embed_frame{position:relative;}.h_iframe-aparat_embed_frame .ratio{display:block;width:100%;height:auto;}.h_iframe-aparat_embed_frame iframe{position:absolute;top:0;left:0;width:100%;height:100%;}</style><div class=\"h_iframe-aparat_embed_frame\"><span style=\"display: block;padding-top: 57%\"></span><iframe src=\"https://www.aparat.com/video/video/embed/videohash/El1US/vt/frame\"  allowFullScreen=\"true\" webkitallowfullscreen=\"true\" mozallowfullscreen=\"true\"></iframe></div>",
                },
                new PropertyVideo
                {
                    Id = 3,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = true,
                    PropertyId = 3,
                    VideoLink = "<style>.h_iframe-aparat_embed_frame{position:relative;}.h_iframe-aparat_embed_frame .ratio{display:block;width:100%;height:auto;}.h_iframe-aparat_embed_frame iframe{position:absolute;top:0;left:0;width:100%;height:100%;}</style><div class=\"h_iframe-aparat_embed_frame\"><span style=\"display: block;padding-top: 57%\"></span><iframe src=\"https://www.aparat.com/video/video/embed/videohash/El1US/vt/frame\"  allowFullScreen=\"true\" webkitallowfullscreen=\"true\" mozallowfullscreen=\"true\"></iframe></div>"
                }
        };

        public static CreatePropertyVideoDTO _createPropertyVideoDTO_Valid = new()
        {
            VideoLink = "123",
            PropertyId = 1,
        };
        public static CreatePropertyVideoDTO _createPropertyVideoDTO_ValidationError_NotExist_Invalid = new CreatePropertyVideoDTO
        {
            PropertyId = 10,
        };
        public static CreatePropertyVideoDTO _createPropertyVideoDTO_ValidationError_Invalid = new CreatePropertyVideoDTO
        {
        };

        public static UpdatePropertyVideoDTO _updatePropertyVideoDTO_Valid = new()
        {
            Id = 1,
            VideoLink = "123",
            PropertyId = 1,
        };
        public static UpdatePropertyVideoDTO _updatePropertyVideoDTO_ValidationError_InValid = new UpdatePropertyVideoDTO
        {
            Id = 1,
        };
        public static UpdatePropertyVideoDTO _updatePropertyVideoDTO_ValidationError_PropertyVideoNotFound_InValid = new UpdatePropertyVideoDTO
        {
            Id = 10,
            PropertyId = 1,
        };
        public static UpdatePropertyVideoDTO _updatePropertyVideoDTO_ValidationError_PropertyNotFound_InValid = new UpdatePropertyVideoDTO
        {
            Id = 1,
            PropertyId = 10,
        };

    }
}
