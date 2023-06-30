namespace Application.DTOs.GeneralSiteInformationsDTO.Banner
{
    public interface IBannerDTO
    {
        public string BannerImage { get; set; }
        public string Link { get; set; }
        public string Alt { get; set; }
        public string Description { get; set; }
    }
}
