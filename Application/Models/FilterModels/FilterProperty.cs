using Application.DTOs.Paging;
using Domain.Entities.Project;
using System.Collections.Generic;

namespace Application.Models.FilterModels
{
    public class FilterProperty : BasePaging
    {
        public List<Property> Properties { get; set; }
        public double MinPrice { get; set; }
        public double MaxPrice { get; set; }
        public long PropertyContractTypeId { get; set; }
        public long PropertyTypeId { get; set; }
        public long CityId { get; set; }
        public int NumberOfBedroom { get; set; }
        public int NumberOfBathroom { get; set; }
        public int FloorSpace { get; set; }//متراژ
        public bool PropertyStatus { get; set; } = true;

        public FilterProperty SetPaging(BasePaging paging)
        {
            PageId = paging.PageId;
            SkipEntity = paging.SkipEntity;
            TakeEntity = paging.TakeEntity;
            ActivePage = paging.ActivePage;
            EndPage = paging.EndPage;
            StartPage = paging.StartPage;
            PageCount = paging.PageCount;
            return this;
        }
        public FilterProperty SetProperties(List<Property> properties)
        {
            Properties = properties;
            return this;
        }

    }
}
